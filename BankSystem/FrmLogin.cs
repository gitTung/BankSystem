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
    public partial class FrmLogin : Form
    {
        private ATM atm;

        public FrmLogin(ATM atm)
        {
            InitializeComponent();
            this.atm = atm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(atm.Login(txtId.Text, txtPwd.Text))
            {   //登陆成功
                new FrmMain(atm).Visible = true;
                Dispose();
            }
            else
            {
                MessageBox.Show("ID或密码错误！");
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmStart(atm).Visible = true;
        }
    }
}