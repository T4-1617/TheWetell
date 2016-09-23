namespace OnlineBooking
{
    partial class Form1
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
            this.cbxSelectUser = new System.Windows.Forms.ComboBox();
            this.pnlOpenNewAccount = new System.Windows.Forms.Panel();
            this.tbxAddAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.pnlCustomerButtons = new System.Windows.Forms.Panel();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnInvolement = new System.Windows.Forms.Button();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.lbxUserAccounts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.pnlWithdrawCash = new System.Windows.Forms.Panel();
            this.tbxWithdraw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAddCash = new System.Windows.Forms.Panel();
            this.tbxAddCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOpenNewAccount.SuspendLayout();
            this.pnlCustomerButtons.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlWithdrawCash.SuspendLayout();
            this.pnlAddCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select user:";
            // 
            // cbxSelectUser
            // 
            this.cbxSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectUser.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxSelectUser.FormattingEnabled = true;
            this.cbxSelectUser.Location = new System.Drawing.Point(16, 52);
            this.cbxSelectUser.Name = "cbxSelectUser";
            this.cbxSelectUser.Size = new System.Drawing.Size(278, 26);
            this.cbxSelectUser.TabIndex = 1;
            this.cbxSelectUser.SelectedIndexChanged += new System.EventHandler(this.cbxSelectUser_SelectedIndexChanged);
            // 
            // pnlOpenNewAccount
            // 
            this.pnlOpenNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpenNewAccount.Controls.Add(this.label7);
            this.pnlOpenNewAccount.Controls.Add(this.tbxAddAccount);
            this.pnlOpenNewAccount.Controls.Add(this.label4);
            this.pnlOpenNewAccount.Controls.Add(this.btnAddAccount);
            this.pnlOpenNewAccount.Location = new System.Drawing.Point(468, 159);
            this.pnlOpenNewAccount.Name = "pnlOpenNewAccount";
            this.pnlOpenNewAccount.Size = new System.Drawing.Size(379, 220);
            this.pnlOpenNewAccount.TabIndex = 2;
            // 
            // tbxAddAccount
            // 
            this.tbxAddAccount.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxAddAccount.Location = new System.Drawing.Point(118, 103);
            this.tbxAddAccount.Name = "tbxAddAccount";
            this.tbxAddAccount.Size = new System.Drawing.Size(146, 26);
            this.tbxAddAccount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(104, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Open new account:";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(89, 149);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(223, 53);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Confirm opening new account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // pnlCustomerButtons
            // 
            this.pnlCustomerButtons.Controls.Add(this.btnWithdrawCash);
            this.pnlCustomerButtons.Controls.Add(this.btnBalance);
            this.pnlCustomerButtons.Controls.Add(this.btnAddCash);
            this.pnlCustomerButtons.Location = new System.Drawing.Point(16, 363);
            this.pnlCustomerButtons.Name = "pnlCustomerButtons";
            this.pnlCustomerButtons.Size = new System.Drawing.Size(278, 99);
            this.pnlCustomerButtons.TabIndex = 3;
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.Font = new System.Drawing.Font("Arial", 10F);
            this.btnWithdrawCash.Location = new System.Drawing.Point(189, 16);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(89, 67);
            this.btnWithdrawCash.TabIndex = 6;
            this.btnWithdrawCash.Text = "Withdraw cash";
            this.btnWithdrawCash.UseVisualStyleBackColor = true;
            this.btnWithdrawCash.Click += new System.EventHandler(this.btnWithdrawCash_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBalance.Location = new System.Drawing.Point(3, 16);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(89, 67);
            this.btnBalance.TabIndex = 4;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnAddCash
            // 
            this.btnAddCash.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddCash.Location = new System.Drawing.Point(96, 16);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(89, 67);
            this.btnAddCash.TabIndex = 5;
            this.btnAddCash.Text = "Add cash";
            this.btnAddCash.UseVisualStyleBackColor = true;
            this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Font = new System.Drawing.Font("Arial", 10F);
            this.btnOpenAccount.Location = new System.Drawing.Point(158, 290);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(92, 67);
            this.btnOpenAccount.TabIndex = 7;
            this.btnOpenAccount.Text = "Open new account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // btnInvolement
            // 
            this.btnInvolement.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInvolement.Location = new System.Drawing.Point(60, 290);
            this.btnInvolement.Name = "btnInvolement";
            this.btnInvolement.Size = new System.Drawing.Size(92, 67);
            this.btnInvolement.TabIndex = 8;
            this.btnInvolement.Text = "\rInvolvement";
            this.btnInvolement.UseVisualStyleBackColor = true;
            // 
            // lbxUsers
            // 
            this.lbxUsers.Font = new System.Drawing.Font("Arial", 10F);
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 16;
            this.lbxUsers.Location = new System.Drawing.Point(16, 102);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(120, 164);
            this.lbxUsers.TabIndex = 9;
            this.lbxUsers.SelectedIndexChanged += new System.EventHandler(this.lbxUsers_SelectedIndexChanged);
            // 
            // lbxUserAccounts
            // 
            this.lbxUserAccounts.Font = new System.Drawing.Font("Arial", 10F);
            this.lbxUserAccounts.FormattingEnabled = true;
            this.lbxUserAccounts.ItemHeight = 16;
            this.lbxUserAccounts.Location = new System.Drawing.Point(174, 102);
            this.lbxUserAccounts.Name = "lbxUserAccounts";
            this.lbxUserAccounts.Size = new System.Drawing.Size(120, 164);
            this.lbxUserAccounts.TabIndex = 10;
            this.lbxUserAccounts.SelectedIndexChanged += new System.EventHandler(this.lbxUserAccounts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Users:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(171, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "User accounts:";
            // 
            // tbxBalance
            // 
            this.tbxBalance.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxBalance.Location = new System.Drawing.Point(110, 3);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(168, 26);
            this.tbxBalance.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Balance:";
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.tbxBalance);
            this.pnlBalance.Controls.Add(this.label5);
            this.pnlBalance.Location = new System.Drawing.Point(16, 468);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(278, 32);
            this.pnlBalance.TabIndex = 19;
            // 
            // pnlWithdrawCash
            // 
            this.pnlWithdrawCash.Controls.Add(this.tbxWithdraw);
            this.pnlWithdrawCash.Controls.Add(this.label6);
            this.pnlWithdrawCash.Location = new System.Drawing.Point(16, 540);
            this.pnlWithdrawCash.Name = "pnlWithdrawCash";
            this.pnlWithdrawCash.Size = new System.Drawing.Size(278, 32);
            this.pnlWithdrawCash.TabIndex = 20;
            // 
            // tbxWithdraw
            // 
            this.tbxWithdraw.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxWithdraw.Location = new System.Drawing.Point(110, 3);
            this.tbxWithdraw.Name = "tbxWithdraw";
            this.tbxWithdraw.Size = new System.Drawing.Size(168, 26);
            this.tbxWithdraw.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Withdraw:";
            // 
            // pnlAddCash
            // 
            this.pnlAddCash.Controls.Add(this.tbxAddCash);
            this.pnlAddCash.Controls.Add(this.label8);
            this.pnlAddCash.Location = new System.Drawing.Point(16, 504);
            this.pnlAddCash.Name = "pnlAddCash";
            this.pnlAddCash.Size = new System.Drawing.Size(278, 32);
            this.pnlAddCash.TabIndex = 20;
            // 
            // tbxAddCash
            // 
            this.tbxAddCash.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxAddCash.Location = new System.Drawing.Point(110, 3);
            this.tbxAddCash.Name = "tbxAddCash";
            this.tbxAddCash.Size = new System.Drawing.Size(168, 26);
            this.tbxAddCash.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Add cash:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(114, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Starting balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 616);
            this.Controls.Add(this.pnlAddCash);
            this.Controls.Add(this.pnlWithdrawCash);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxUserAccounts);
            this.Controls.Add(this.lbxUsers);
            this.Controls.Add(this.btnInvolement);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.pnlCustomerButtons);
            this.Controls.Add(this.pnlOpenNewAccount);
            this.Controls.Add(this.cbxSelectUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lis";
            this.pnlOpenNewAccount.ResumeLayout(false);
            this.pnlOpenNewAccount.PerformLayout();
            this.pnlCustomerButtons.ResumeLayout(false);
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlWithdrawCash.ResumeLayout(false);
            this.pnlWithdrawCash.PerformLayout();
            this.pnlAddCash.ResumeLayout(false);
            this.pnlAddCash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelectUser;
        private System.Windows.Forms.Panel pnlOpenNewAccount;
        private System.Windows.Forms.Panel pnlCustomerButtons;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnInvolement;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.ListBox lbxUserAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox tbxAddAccount;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlWithdrawCash;
        private System.Windows.Forms.TextBox tbxWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAddCash;
        private System.Windows.Forms.TextBox tbxAddCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

