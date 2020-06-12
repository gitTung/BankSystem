using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class CreditAccount : Account
    {
        protected decimal credit;       //总信用额度
        protected decimal usedCredit;   //已经使用的额度

        public decimal Credit
        {
            get
            {
                return credit;
            }
        }
        public decimal UsedCredit
        {
            get
            {
                return usedCredit;
            }
        }
        public decimal UnusedCredit
        {
            get
            {
                return Credit - UsedCredit;
            }
        }

        public CreditAccount(Account account, decimal credit)
            : base(account.Id, account.Username, account.Password, account.Money)//调用父类构造方法
        {
            this.credit = credit;
            this.usedCredit = 0;
        }

        /// <summary>
        /// 提升额度
        /// </summary>
        /// <param name="upCredit">增加的额度值，应为正数</param>
        public void CreditUp(decimal upCredit)
        {
            if (upCredit > 0)
                credit += upCredit;
        }

        /// <summary>
        /// 取款(可透支)
        /// </summary>
        /// <param name="value">取款数额</param>
        /// <returns></returns>
        public override bool Withdraw(decimal value)
        {
            if (money + usedCredit < value)
                return false;   //余额和额度不足，取款失败
            if (new Random().Next(3) < 1)   //三分之一的概率出现坏钞
                throw new BadCashException();
            if (money > value)
            {
                money -= value; //正常取款
                return true;
            }
            else
            {
                usedCredit += (value - Money);  //透支取款
                money = 0;
                return true;
            }
        }

        /// <summary>
        /// 该方法用于往账户中存钱,但优先还款
        /// </summary>
        /// <param name="value">存入金额</param>
        /// <returns>操作后的账户余额</returns>
        public override decimal SaveMoney(decimal value)
        {
            if (usedCredit >= value)
                usedCredit -= value;
            else
            {
                money += (value - usedCredit);
                usedCredit = 0;
            }
            return money;
        }
    }
}
