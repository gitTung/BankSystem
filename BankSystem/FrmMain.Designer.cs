namespace BankSystem
{
    partial class FrmMain
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnCreditOpen = new System.Windows.Forms.Button();
            this.btnCreditUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(129, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "一夜暴富银行\r\nATM存取款机";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(331, 398);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(84, 34);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "取款";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "存款";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("宋体", 15F);
            this.txtMoney.Location = new System.Drawing.Point(257, 334);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(177, 36);
            this.txtMoney.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(137, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入金额:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("宋体", 15F);
            this.lblMoney.Location = new System.Drawing.Point(133, 185);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(137, 25);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "账户余额：";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("宋体", 15F);
            this.lblCredit.Location = new System.Drawing.Point(133, 231);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(112, 25);
            this.lblCredit.TabIndex = 7;
            this.lblCredit.Text = "信用额度";
            // 
            // btnCreditOpen
            // 
            this.btnCreditOpen.Location = new System.Drawing.Point(138, 259);
            this.btnCreditOpen.Name = "btnCreditOpen";
            this.btnCreditOpen.Size = new System.Drawing.Size(167, 29);
            this.btnCreditOpen.TabIndex = 8;
            this.btnCreditOpen.Text = "开通信用卡服务";
            this.btnCreditOpen.UseVisualStyleBackColor = true;
            this.btnCreditOpen.Visible = false;
            this.btnCreditOpen.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCreditUp
            // 
            this.btnCreditUp.Location = new System.Drawing.Point(138, 291);
            this.btnCreditUp.Name = "btnCreditUp";
            this.btnCreditUp.Size = new System.Drawing.Size(132, 35);
            this.btnCreditUp.TabIndex = 9;
            this.btnCreditUp.Text = "申请提额";
            this.btnCreditUp.UseVisualStyleBackColor = true;
            this.btnCreditUp.Visible = false;
            this.btnCreditUp.Click += new System.EventHandler(this.btnCreditUp_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 491);
            this.Controls.Add(this.btnCreditUp);
            this.Controls.Add(this.btnCreditOpen);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnCreditOpen;
        private System.Windows.Forms.Button btnCreditUp;
    }
}