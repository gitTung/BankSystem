using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BigMoneyArgs
    {
        private string id;
        private decimal money;

        public string Id
        {
            get
            {
                return id;
            }
        }

        public decimal Money
        {
            get
            {
                return money;
            }
        }

        public BigMoneyArgs(string id,decimal money)
        {
            this.id = id;
            this.money = money;
        }
    }
}
