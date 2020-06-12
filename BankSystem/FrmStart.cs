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
    public partial class FrmStart : Form
    {
        private ATM atm;
        public FrmStart(ATM atm)
        {
            InitializeComponent();
            this.atm = atm;
            atm.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FrmLogin(atm).Visible = true;
            Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FrmRegister(atm).Visible = true;
            Dispose();
        }

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            atm.Close();
        }
    }
}
