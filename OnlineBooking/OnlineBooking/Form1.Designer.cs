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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlCustomerButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(372, 48);
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
            this.cbxSelectUser.Location = new System.Drawing.Point(295, 76);
            this.cbxSelectUser.Name = "cbxSelectUser";
            this.cbxSelectUser.Size = new System.Drawing.Size(278, 26);
            this.cbxSelectUser.TabIndex = 1;
            this.cbxSelectUser.SelectedIndexChanged += new System.EventHandler(this.cbxSelectUser_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxAddAccount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Location = new System.Drawing.Point(844, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 220);
            this.panel1.TabIndex = 2;
            // 
            // tbxAddAccount
            // 
            this.tbxAddAccount.Font = new System.Drawing.Font("Arial", 12F);
            this.tbxAddAccount.Location = new System.Drawing.Point(113, 107);
            this.tbxAddAccount.Name = "tbxAddAccount";
            this.tbxAddAccount.Size = new System.Drawing.Size(168, 26);
            this.tbxAddAccount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(109, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Open new account:";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(84, 150);
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
            this.pnlCustomerButtons.Location = new System.Drawing.Point(358, 296);
            this.pnlCustomerButtons.Name = "pnlCustomerButtons";
            this.pnlCustomerButtons.Size = new System.Drawing.Size(301, 99);
            this.pnlCustomerButtons.TabIndex = 3;
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.Font = new System.Drawing.Font("Arial", 10F);
            this.btnWithdrawCash.Location = new System.Drawing.Point(203, 16);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(92, 67);
            this.btnWithdrawCash.TabIndex = 6;
            this.btnWithdrawCash.Text = "Withdraw cash";
            this.btnWithdrawCash.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBalance.Location = new System.Drawing.Point(7, 16);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(92, 67);
            this.btnBalance.TabIndex = 4;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnAddCash
            // 
            this.btnAddCash.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddCash.Location = new System.Drawing.Point(105, 16);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(92, 67);
            this.btnAddCash.TabIndex = 5;
            this.btnAddCash.Text = "Add cash";
            this.btnAddCash.UseVisualStyleBackColor = true;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Font = new System.Drawing.Font("Arial", 10F);
            this.btnOpenAccount.Location = new System.Drawing.Point(260, 312);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(92, 67);
            this.btnOpenAccount.TabIndex = 7;
            this.btnOpenAccount.Text = "Open new account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // btnInvolement
            // 
            this.btnInvolement.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInvolement.Location = new System.Drawing.Point(162, 312);
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
            this.lbxUsers.Location = new System.Drawing.Point(295, 126);
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
            this.lbxUserAccounts.Location = new System.Drawing.Point(453, 126);
            this.lbxUserAccounts.Name = "lbxUserAccounts";
            this.lbxUserAccounts.Size = new System.Drawing.Size(120, 164);
            this.lbxUserAccounts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(292, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Users:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(450, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "User accounts:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(247, 759);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 26);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox2.Location = new System.Drawing.Point(247, 791);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox3.Location = new System.Drawing.Point(247, 823);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 26);
            this.textBox3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 885);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxUserAccounts);
            this.Controls.Add(this.lbxUsers);
            this.Controls.Add(this.btnInvolement);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.pnlCustomerButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxSelectUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomerButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelectUser;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

