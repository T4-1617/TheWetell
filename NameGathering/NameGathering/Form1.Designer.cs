namespace NameGathering
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.rBtnCustomer = new System.Windows.Forms.RadioButton();
            this.rBtnEmployee = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(171, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLastName.Location = new System.Drawing.Point(171, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // rBtnCustomer
            // 
            this.rBtnCustomer.AutoSize = true;
            this.rBtnCustomer.Font = new System.Drawing.Font("Arial", 14F);
            this.rBtnCustomer.Location = new System.Drawing.Point(32, 118);
            this.rBtnCustomer.Name = "rBtnCustomer";
            this.rBtnCustomer.Size = new System.Drawing.Size(111, 26);
            this.rBtnCustomer.TabIndex = 4;
            this.rBtnCustomer.TabStop = true;
            this.rBtnCustomer.Text = "Customer";
            this.rBtnCustomer.UseVisualStyleBackColor = true;
            // 
            // rBtnEmployee
            // 
            this.rBtnEmployee.AutoSize = true;
            this.rBtnEmployee.Font = new System.Drawing.Font("Arial", 14F);
            this.rBtnEmployee.Location = new System.Drawing.Point(149, 118);
            this.rBtnEmployee.Name = "rBtnEmployee";
            this.rBtnEmployee.Size = new System.Drawing.Size(114, 26);
            this.rBtnEmployee.TabIndex = 5;
            this.rBtnEmployee.TabStop = true;
            this.rBtnEmployee.Text = "Employee";
            this.rBtnEmployee.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14F);
            this.button1.Location = new System.Drawing.Point(269, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Arial", 14F);
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 22;
            this.listBoxCustomers.Location = new System.Drawing.Point(32, 205);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(297, 114);
            this.listBoxCustomers.TabIndex = 7;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Arial", 14F);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 22;
            this.listBoxEmployees.Location = new System.Drawing.Point(32, 377);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(297, 114);
            this.listBoxEmployees.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(27, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(27, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employees:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rBtnEmployee);
            this.Controls.Add(this.rBtnCustomer);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.RadioButton rBtnCustomer;
        private System.Windows.Forms.RadioButton rBtnEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

