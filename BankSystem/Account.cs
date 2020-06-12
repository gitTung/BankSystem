using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    /// <summary>
    /// 账户类，可进行存取款操作
    /// </summary>
    public class Account
    {
        //改进说明：原本使用了自动属性
        //现在改成了字段+属性，属性在类外是只读的，只有在类内可以对字段实现读和写
        //这样增强了类的封装性和安全性
        //在子类CreditAccount中也对此进行了改进
        protected string id;
        protected string username;
        protected string password;
        protected decimal money;

        public string Id
        {
            get
            {
                return id;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
        }
        public decimal Money
        {
            get
            {
                return money;
            }
        }

        public Account(string id, string username, string password, decimal money)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.money = money;
        }

        /// <summary>
        /// 该方法用于往账户中存钱
        /// </summary>
        /// <param name="value">存入金额</param>
        /// <returns>操作后的账户余额</returns>
        public virtual decimal SaveMoney(decimal value)
        {
            return money += value;
        }

        /// <summary>
        /// 该方法用于从账户中取款
        /// </summary>
        /// <param name="value">取款金额</param>
        /// <returns>取款是否成功</returns>
        public virtual bool Withdraw(decimal value)
        {
            if (Money < value)
                return false;   //余额不足，取款失败
            if (new Random().Next(3) < 1)       //三分之一的概率出现坏钞
                throw new BadCashException();
            money -= value;
            return true;
        }

    }
}
