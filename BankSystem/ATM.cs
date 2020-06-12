using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    /// <summary>
    /// 该类提供ATM操作的相关方法
    /// 该类虽然继承自From，但不用于展示界面，成员atmForm用于展示界面，并在构造函数中构造生成
    /// </summary>
    public partial class ATM : Form,IMoneyStorable
    {
        private Bank bank;      //ATM所依附的银行
        private decimal money;  //ATM机中的总金额
        private Account account;//已登录的账户

        public delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyArgs e);    //定义委托
        public event BigMoneyFetchedEventHandler BigMoneyFeched;   //定义事件

        private FrmStart atmForm;

        public ATM(Bank bank, decimal money)
        {
            InitializeComponent();

            this.bank = bank;
            this.money = money;
            account = null;     //未登录状态
            atmForm = new FrmStart(this);
            atmForm.Visible = true;
            //注册事件(把事件处理的方法用lambda表达式的方式直接注册，不用再写一个对应的方法)
            BigMoneyFeched += (sender, e) => MessageBox.Show($"一大笔钱被取走了，请注意！\r\n详情：账户{e.Id}被取走了{e.Money}元钱");
        }

        /// <summary>
        /// 获取登录的账户
        /// </summary>
        /// <returns></returns>
        public Account GetAccount()
        {
            return account;
        }

        /// <summary>
        /// 账户登录，将登录成功的账户存入account中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns>登录是否成功</returns>
        public bool Login(string id, string pwd)
        {
            if ((account = bank.Login(id, pwd)) != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 将当前登录的账户升级为信用账户
        /// </summary>
        /// <param name="credit">信用额度</param>
        public void changeToCredit(decimal credit)
        {
            bank.changeToCreditAccount(account.Id, credit);
            account = bank.FindAccount(account.Id);
        }

        /// <summary>
        /// 注册账户，并将注册后的账户存入account中(自动登录)
        /// </summary>
        /// <param name="username">账户名(真实姓名)</param>
        /// <param name="password">账户密码</param>
        /// <param name="money">开户初始金额</param>
        /// <returns>注册后的账户对象</returns>
        public Account Register(string username, string password, decimal money)
        {
            this.money += money;    //ATM机中的钱增加
            return account = bank.OpenAccount(username, password, money);
        }

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="money">存入的款数</param>
        public void SaveMoney(decimal money)
        {
            if (account == null)
                return;
            if (money > 0)
            {
                account.SaveMoney(money);
                this.money += money;
            }
        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="money">取出的金额</param>
        /// <returns>取款是否成功</returns>
        public bool Withdraw(decimal money)
        {
            if (account == null || money > this.money)
                return false;
            try
            {
                if (account.Withdraw(money))
                {
                    this.money -= money;
                    if (money >= 10000 && BigMoneyFeched != null)
                        BigMoneyFeched(this, new BigMoneyArgs(account.Id, money));
                    return true;
                }
            }catch(BadCashException e)
            {
                MessageBox.Show("出现坏钞了！");
            }
            return false;
        }

        /// <summary>
        /// 提升信用额度
        /// </summary>
        /// <param name="credit">提升至额度，应比当前额度高</param>
        /// <returns></returns>
        public decimal CreditUpTo(decimal credit)
        {
            if (!(account is CreditAccount))
                return 0;
            CreditAccount cAcc = account as CreditAccount;
            decimal upCredit = credit - cAcc.Credit;
            upCredit = upCredit > 0 ? upCredit : 0;
            cAcc.CreditUp(upCredit);
            return upCredit;
        }

        private void ATM_Shown(object sender, EventArgs e)
        {
            this.Visible = false;   //自动隐藏窗口
        }

        public decimal IncreaseMoney(decimal value)
        {
            return money += value;
        }

        public bool DecreaseMoney(decimal value)
        {
            if (money < value)
                return false;   //金额不够，无法减少
            money -= value;
            return true;
        }

        public bool TransferMoneyTo(IMoneyStorable moneyStorage, decimal value)
        {
            if (money < value)
                return false;   //金额不够，无法调配给该对象
            money -= value;
            moneyStorage.IncreaseMoney(value);
            return true;
        }

        private void ATM_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("祝您一夜暴富！");
        }
    }
}
