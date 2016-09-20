namespace CRM
{
    partial class CRM
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
            this.cbRegister = new System.Windows.Forms.ComboBox();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnSaveReg = new System.Windows.Forms.Button();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.pnlCustomerReg = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbPersonList = new System.Windows.Forms.ListBox();
            this.pnlEditInfo = new System.Windows.Forms.Panel();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.lblCountingPeople = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pnlRegistration.SuspendLayout();
            this.pnlCustomerReg.SuspendLayout();
            this.pnlEditInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "I want to register a new:";
            // 
            // cbRegister
            // 
            this.cbRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegister.FormattingEnabled = true;
            this.cbRegister.Location = new System.Drawing.Point(263, 24);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(319, 21);
            this.cbRegister.TabIndex = 1;
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Controls.Add(this.pnlCustomerReg);
            this.pnlRegistration.Controls.Add(this.btnCancelReg);
            this.pnlRegistration.Controls.Add(this.btnSaveReg);
            this.pnlRegistration.Location = new System.Drawing.Point(53, 91);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(529, 179);
            this.pnlRegistration.TabIndex = 2;
            // 
            // btnSaveReg
            // 
            this.btnSaveReg.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSaveReg.Location = new System.Drawing.Point(308, 135);
            this.btnSaveReg.Name = "btnSaveReg";
            this.btnSaveReg.Size = new System.Drawing.Size(81, 32);
            this.btnSaveReg.TabIndex = 0;
            this.btnSaveReg.Text = "Save";
            this.btnSaveReg.UseVisualStyleBackColor = true;
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancelReg.Location = new System.Drawing.Point(407, 135);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(81, 32);
            this.btnCancelReg.TabIndex = 1;
            this.btnCancelReg.Text = "Cancel";
            this.btnCancelReg.UseVisualStyleBackColor = true;
            // 
            // pnlCustomerReg
            // 
            this.pnlCustomerReg.Controls.Add(this.label8);
            this.pnlCustomerReg.Controls.Add(this.textBox6);
            this.pnlCustomerReg.Controls.Add(this.label9);
            this.pnlCustomerReg.Controls.Add(this.textBox7);
            this.pnlCustomerReg.Controls.Add(this.label5);
            this.pnlCustomerReg.Controls.Add(this.textBox3);
            this.pnlCustomerReg.Controls.Add(this.label4);
            this.pnlCustomerReg.Controls.Add(this.textBox2);
            this.pnlCustomerReg.Controls.Add(this.label3);
            this.pnlCustomerReg.Controls.Add(this.textBox1);
            this.pnlCustomerReg.Controls.Add(this.label2);
            this.pnlCustomerReg.Controls.Add(this.txtFirstName);
            this.pnlCustomerReg.Location = new System.Drawing.Point(3, 4);
            this.pnlCustomerReg.Name = "pnlCustomerReg";
            this.pnlCustomerReg.Size = new System.Drawing.Size(523, 125);
            this.pnlCustomerReg.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(113, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lbPersonList
            // 
            this.lbPersonList.FormattingEnabled = true;
            this.lbPersonList.Location = new System.Drawing.Point(53, 358);
            this.lbPersonList.Name = "lbPersonList";
            this.lbPersonList.Size = new System.Drawing.Size(120, 212);
            this.lbPersonList.TabIndex = 3;
            // 
            // pnlEditInfo
            // 
            this.pnlEditInfo.Controls.Add(this.btnCancelEdit);
            this.pnlEditInfo.Controls.Add(this.btnSaveEdit);
            this.pnlEditInfo.Location = new System.Drawing.Point(194, 358);
            this.pnlEditInfo.Name = "pnlEditInfo";
            this.pnlEditInfo.Size = new System.Drawing.Size(388, 212);
            this.pnlEditInfo.TabIndex = 4;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSaveEdit.Location = new System.Drawing.Point(191, 177);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(81, 32);
            this.btnSaveEdit.TabIndex = 4;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancelEdit.Location = new System.Drawing.Point(290, 177);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(81, 32);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // lblCountingPeople
            // 
            this.lblCountingPeople.AutoSize = true;
            this.lblCountingPeople.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCountingPeople.Location = new System.Drawing.Point(50, 306);
            this.lblCountingPeople.Name = "lblCountingPeople";
            this.lblCountingPeople.Size = new System.Drawing.Size(466, 18);
            this.lblCountingPeople.TabIndex = 5;
            this.lblCountingPeople.Text = "You have registered 0 customer(s), 0 emplyee(s) and 0 supplier(s).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(289, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Titel:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(289, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Company:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(403, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(289, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Salary:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(403, 30);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 20);
            this.textBox7.TabIndex = 8;
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 582);
            this.Controls.Add(this.lblCountingPeople);
            this.Controls.Add(this.pnlEditInfo);
            this.Controls.Add(this.lbPersonList);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.cbRegister);
            this.Controls.Add(this.label1);
            this.Name = "CRM";
            this.Text = "CRM";
            this.pnlRegistration.ResumeLayout(false);
            this.pnlCustomerReg.ResumeLayout(false);
            this.pnlCustomerReg.PerformLayout();
            this.pnlEditInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegister;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Panel pnlCustomerReg;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCancelReg;
        private System.Windows.Forms.Button btnSaveReg;
        private System.Windows.Forms.ListBox lbPersonList;
        private System.Windows.Forms.Panel pnlEditInfo;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblCountingPeople;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

