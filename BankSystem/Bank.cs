using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank: IMoneyStorable
    {
        private decimal money;  //银行存储的金钱总额
        private List<Account> accounts = new List<Account>();

        /// <summary>
        /// 账户数目的属性
        /// </summary>
        public int Count
        {
            get
            {
                return accounts.ToArray().Length;
            }
        }

        /// <summary>
        /// 用于查找和修改、删除、添加账户的索引器
        /// 为保证封装性，该检索器仅在类内可以使用
        /// 查找：根据id进行检索，并返回对象。不存在返回null
        /// 修改：若id存在，且value不为null，进行修改
        /// 删除：若id存在，且value为null，则移除
        /// 添加：若id不存在，且value不为null，则添加
        /// </summary>
        /// <param name="id">账户id</param>
        /// <returns>查到返回账户对象，否则返回null</returns>
        private Account this[string id]
        {
            get
            {
                foreach (Account account in accounts)
                {
                    if (account.Id.Equals(id))
                        return account;
                }
                return null;
            }
            set
            {
                for(int index = 0; index < Count; index++)
                {
                    //如果列表中存在
                    if (accounts[index].Id.Equals(id))
                    {
                        if (value != null)
                            accounts[index] = value;
                        else
                            accounts.RemoveAt(index);
                        return;
                    }
                }
                //列表中不存在
                if(value != null)
                    accounts.Add(value);
            }
        }

        /// <summary>
        /// 银行开户
        /// </summary>
        /// <param name="username">户主姓名</param>
        /// <param name="password">账户密码</param>
        /// <param name="money">初始余额</param>
        /// <returns>账户对象</returns>
        public Account OpenAccount(string username, string password, decimal money)
        {
            string id = DateTime.Now.ToString("yyyyMMddHHmmss");//自动生成id(假设以日期加时间作为Id，如20200321132456)
            Account account = new Account(id, username, password, money);
            accounts.Add(account);
            return account;
        }

        /// <summary>
        /// 根据id查询某一账户
        /// </summary>
        /// <param name="id">待查找的账户id</param>
        /// <returns>查到返回账户对象，否则返回null</returns>
        public Account FindAccount(string id)
        {
            return this[id];
        }

        /// <summary>
        /// 销户
        /// </summary>
        /// <param name="id">待销户的账户id</param>
        /// <returns>销户是否成功</returns>
        public bool CloseAccount(string id)
        {
            if(this[id] != null && this[id].Money != 0)
            {
                this[id] = null;
                return true;
            }
            return false;   //账户或余额不为0
        }

        /// <summary>
        /// 账户登录服务
        /// </summary>
        /// <param name="id">账户id</param>
        /// <param name="pwd">账户密码</param>
        /// <returns>登陆成功返回账户对象，否则返回null</returns>
        public Account Login(string id, string pwd)
        {
            Account account = this[id];
            if (account != null && account.Password.Equals(pwd))
                return account;
            else
                return null;
        }

        /// <summary>
        /// 将普通账户升级为信用卡账户
        /// </summary>
        /// <param name="id">账户id</param>
        /// <param name="credit">信用额度</param>
        /// <returns>是否成功</returns>
        public bool changeToCreditAccount(string id, decimal credit)
        {
            Account acc = this[id];
            if (acc == null || acc is CreditAccount)
                return false;   //账户不存在或已经是信用卡账户，无需升级
            this[id] = new CreditAccount(acc, credit);  //升级并更新原账户
            return true;
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
    }
}
