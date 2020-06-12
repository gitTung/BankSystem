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
    public partial class FrmRegister : Form
    {
        private ATM atm;
        public FrmRegister(ATM atm)
        {
            InitializeComponent();
            this.atm = atm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            decimal money = 0;
            decimal.TryParse(txtMoney.Text, out money);
            if (txtName.Text.Equals(""))
                MessageBox.Show("姓名不能为空");
            else if (txtPwd.TextLength < 6 || txtPwd.TextLength > 20)
                MessageBox.Show("密码长度应为6~20个字符");
            else if (!txtPwd.Text.Equals(txtPwdAgain.Text))
                MessageBox.Show("两次密码输入不一致");
            else if (money < 100)
                MessageBox.Show("你至少要存入一百块才可以开户");
            else
            {
                Account account = atm.Register(txtName.Text, txtPwd.Text, money);
                if (cbCredit.Checked)
                {
                    if(money >= 1000)
                    {
                    decimal credit = ((long)money / 1000) * 100;
                    atm.changeToCredit(credit);
                    MessageBox.Show($"根据您的存入金额评估，您将获得{credit}的信用额度，您可以稍后申请提额");
                    }
                    else
                    {
                        MessageBox.Show("存入金额不足1000元，无法开通信用账户。您可以稍后再次申请开通！");
                    }
                }
                MessageBox.Show($"注册成功，你的ID是{account.Id},请牢记账户ID和登陆密码!");
                new FrmMain(atm).Visible = true;
                Dispose();
            }
        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmStart(atm).Visible = true;
        }
    }
}
