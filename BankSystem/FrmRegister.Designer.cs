namespace BankSystem
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cbCredit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(195, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户注册";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(222, 284);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 39);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(222, 125);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(157, 25);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Tag = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "真实姓名：";
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(222, 165);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(157, 25);
            this.txtPwdAgain.TabIndex = 3;
            this.txtPwdAgain.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "重复密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "存入余额：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(222, 208);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(157, 25);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.Tag = "";
            // 
            // cbCredit
            // 
            this.cbCredit.AutoSize = true;
            this.cbCredit.Location = new System.Drawing.Point(124, 248);
            this.cbCredit.Name = "cbCredit";
            this.cbCredit.Size = new System.Drawing.Size(300, 19);
            this.cbCredit.TabIndex = 5;
            this.cbCredit.Text = "同时开通信用卡账户(需要至少存入一千)";
            this.cbCredit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbCredit.UseVisualStyleBackColor = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 342);
            this.Controls.Add(this.cbCredit);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPwdAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegister_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.CheckBox cbCredit;
    }
}