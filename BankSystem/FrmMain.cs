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
    public partial class FrmMain : Form
    {
        private ATM atm;
        public FrmMain(ATM atm)
        {
            InitializeComponent();
            this.atm = atm;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowMoney();
        }

        private void ShowMoney()
        {
            Account acc = atm.GetAccount();
            lblMoney.Text = "账户余额：" + acc.Money+"元";
            if (acc is CreditAccount)
            {
                CreditAccount cAcc = acc as CreditAccount;
                lblCredit.Text = $"信用总额度：{cAcc.Credit}元\r\n已透支取款：{cAcc.UsedCredit}元";
                btnCreditOpen.Visible = false;
                lblCredit.Visible = true;
                btnCreditUp.Visible = true;
            }
            else
            {
                lblCredit.Visible = false;
                btnCreditUp.Visible = false;
                btnCreditOpen.Visible = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("已注销！");
            new FrmStart(atm).Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal money = 0;
            decimal.TryParse(txtMoney.Text, out money);
            if (money <= 0)
            {
                MessageBox.Show("存钱失败，请检查输入...");
            }
            else
            {
                atm.SaveMoney(money);
                ShowMoney();
                MessageBox.Show("存钱成功，祝您一夜暴富！");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal money = 0;
            decimal.TryParse(txtMoney.Text, out money);
            if (money <= 0)
            {
                MessageBox.Show("取钱失败，请检查输入...");
            }
            else if(atm.Withdraw(money))
            {
                ShowMoney();
                MessageBox.Show("取钱成功，祝您一夜暴富！");
            }
            else
            {
                MessageBox.Show("取钱失败...");
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            decimal money = atm.GetAccount().Money;
            if (money >= 1000)
            {
                decimal credit = ((long)money / 1000) * 100;
                atm.changeToCredit(credit);
                ShowMoney();
                MessageBox.Show($"开通成功，根据您当前的存款评估，您已获得{credit}的信用额度。尽情透支消费吧！");
            }
            else
                MessageBox.Show("您需要保证有至少1000的存款才可开通");
        }

        private void btnCreditUp_Click(object sender, EventArgs e)
        {
            decimal money = atm.GetAccount().Money;
            decimal credit = 0;
            credit = ((long)money / 1000) * 100;
            decimal up = atm.CreditUpTo(credit);
            ShowMoney();
            MessageBox.Show($"根据您当前的存款评估，您的额度提升了{up}元");
        }
    }
}
