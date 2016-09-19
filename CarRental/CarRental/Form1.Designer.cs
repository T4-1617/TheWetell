namespace CarRental
{
    partial class CarRental
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
            this.btnShowAvailableCars = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblCountCars = new System.Windows.Forms.Label();
            this.pnlAvailableCars = new System.Windows.Forms.Panel();
            this.groupBoxAvailableCars = new System.Windows.Forms.GroupBox();
            this.btnBookCar = new System.Windows.Forms.Button();
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.pnlThankYouBooking = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxAddCar = new System.Windows.Forms.GroupBox();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRetunCar = new System.Windows.Forms.Panel();
            this.groupBoxReturnCar = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.listBoxReturnCars = new System.Windows.Forms.ListBox();
            this.pnlReturnThanks = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.pnlShowCustomers = new System.Windows.Forms.Panel();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.pnlAvailableCars.SuspendLayout();
            this.groupBoxAvailableCars.SuspendLayout();
            this.pnlThankYouBooking.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.groupBoxAddCar.SuspendLayout();
            this.pnlRetunCar.SuspendLayout();
            this.groupBoxReturnCar.SuspendLayout();
            this.pnlReturnThanks.SuspendLayout();
            this.pnlShowCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAvailableCars
            // 
            this.btnShowAvailableCars.Font = new System.Drawing.Font("Arial", 20F);
            this.btnShowAvailableCars.Location = new System.Drawing.Point(18, 73);
            this.btnShowAvailableCars.Name = "btnShowAvailableCars";
            this.btnShowAvailableCars.Size = new System.Drawing.Size(116, 97);
            this.btnShowAvailableCars.TabIndex = 0;
            this.btnShowAvailableCars.Text = "Show Cars";
            this.btnShowAvailableCars.UseVisualStyleBackColor = true;
            this.btnShowAvailableCars.Click += new System.EventHandler(this.btnShowAvailableCars_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Arial", 20F);
            this.btnAddCar.Location = new System.Drawing.Point(158, 73);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(116, 97);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblCountCars
            // 
            this.lblCountCars.AutoSize = true;
            this.lblCountCars.Font = new System.Drawing.Font("Arial", 24F);
            this.lblCountCars.Location = new System.Drawing.Point(3, 9);
            this.lblCountCars.Name = "lblCountCars";
            this.lblCountCars.Size = new System.Drawing.Size(365, 36);
            this.lblCountCars.TabIndex = 3;
            this.lblCountCars.Text = "We have 3 cars available";
            // 
            // pnlAvailableCars
            // 
            this.pnlAvailableCars.Controls.Add(this.groupBoxAvailableCars);
            this.pnlAvailableCars.Location = new System.Drawing.Point(9, 179);
            this.pnlAvailableCars.Name = "pnlAvailableCars";
            this.pnlAvailableCars.Size = new System.Drawing.Size(960, 400);
            this.pnlAvailableCars.TabIndex = 4;
            // 
            // groupBoxAvailableCars
            // 
            this.groupBoxAvailableCars.Controls.Add(this.btnBookCar);
            this.groupBoxAvailableCars.Controls.Add(this.label10);
            this.groupBoxAvailableCars.Controls.Add(this.txtLastName);
            this.groupBoxAvailableCars.Controls.Add(this.label8);
            this.groupBoxAvailableCars.Controls.Add(this.listBoxAvailableCars);
            this.groupBoxAvailableCars.Controls.Add(this.txtFirstName);
            this.groupBoxAvailableCars.Controls.Add(this.label1);
            this.groupBoxAvailableCars.Font = new System.Drawing.Font("Arial", 16F);
            this.groupBoxAvailableCars.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAvailableCars.Name = "groupBoxAvailableCars";
            this.groupBoxAvailableCars.Size = new System.Drawing.Size(901, 336);
            this.groupBoxAvailableCars.TabIndex = 1;
            this.groupBoxAvailableCars.TabStop = false;
            this.groupBoxAvailableCars.Text = "Available Cars";
            // 
            // btnBookCar
            // 
            this.btnBookCar.Font = new System.Drawing.Font("Arial", 50F);
            this.btnBookCar.Location = new System.Drawing.Point(341, 201);
            this.btnBookCar.Name = "btnBookCar";
            this.btnBookCar.Size = new System.Drawing.Size(204, 122);
            this.btnBookCar.TabIndex = 1;
            this.btnBookCar.Text = "Book";
            this.btnBookCar.UseVisualStyleBackColor = true;
            this.btnBookCar.Click += new System.EventHandler(this.btnBookCar_Click);
            // 
            // listBoxAvailableCars
            // 
            this.listBoxAvailableCars.Font = new System.Drawing.Font("Arial", 20F);
            this.listBoxAvailableCars.FormattingEnabled = true;
            this.listBoxAvailableCars.ItemHeight = 32;
            this.listBoxAvailableCars.Location = new System.Drawing.Point(6, 31);
            this.listBoxAvailableCars.Name = "listBoxAvailableCars";
            this.listBoxAvailableCars.Size = new System.Drawing.Size(327, 292);
            this.listBoxAvailableCars.TabIndex = 0;
            // 
            // pnlThankYouBooking
            // 
            this.pnlThankYouBooking.Controls.Add(this.label2);
            this.pnlThankYouBooking.Location = new System.Drawing.Point(2, 188);
            this.pnlThankYouBooking.Name = "pnlThankYouBooking";
            this.pnlThankYouBooking.Size = new System.Drawing.Size(960, 394);
            this.pnlThankYouBooking.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 50F);
            this.label2.Location = new System.Drawing.Point(46, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(864, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thank you for your booking!";
            // 
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.btnAdd);
            this.pnlAddCar.Controls.Add(this.groupBoxAddCar);
            this.pnlAddCar.Location = new System.Drawing.Point(3, 179);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(960, 400);
            this.pnlAddCar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 50F);
            this.btnAdd.Location = new System.Drawing.Point(358, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 122);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxAddCar
            // 
            this.groupBoxAddCar.Controls.Add(this.txtMilage);
            this.groupBoxAddCar.Controls.Add(this.txtSeats);
            this.groupBoxAddCar.Controls.Add(this.txtColour);
            this.groupBoxAddCar.Controls.Add(this.txtModel);
            this.groupBoxAddCar.Controls.Add(this.txtMake);
            this.groupBoxAddCar.Controls.Add(this.label7);
            this.groupBoxAddCar.Controls.Add(this.label6);
            this.groupBoxAddCar.Controls.Add(this.label5);
            this.groupBoxAddCar.Controls.Add(this.label4);
            this.groupBoxAddCar.Controls.Add(this.label3);
            this.groupBoxAddCar.Font = new System.Drawing.Font("Arial", 30F);
            this.groupBoxAddCar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddCar.Name = "groupBoxAddCar";
            this.groupBoxAddCar.Size = new System.Drawing.Size(352, 375);
            this.groupBoxAddCar.TabIndex = 0;
            this.groupBoxAddCar.TabStop = false;
            this.groupBoxAddCar.Text = "Add Car";
            // 
            // txtMilage
            // 
            this.txtMilage.Font = new System.Drawing.Font("Arial", 15F);
            this.txtMilage.Location = new System.Drawing.Point(169, 275);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(143, 30);
            this.txtMilage.TabIndex = 10;
            this.txtMilage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilage_KeyPress);
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSeats.Location = new System.Drawing.Point(171, 233);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(143, 30);
            this.txtSeats.TabIndex = 9;
            this.txtSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeats_KeyPress);
            // 
            // txtColour
            // 
            this.txtColour.Font = new System.Drawing.Font("Arial", 15F);
            this.txtColour.Location = new System.Drawing.Point(169, 191);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(143, 30);
            this.txtColour.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 15F);
            this.txtModel.Location = new System.Drawing.Point(169, 148);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(143, 30);
            this.txtModel.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Arial", 15F);
            this.txtMake.Location = new System.Drawing.Point(169, 107);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(143, 30);
            this.txtMake.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F);
            this.label7.Location = new System.Drawing.Point(32, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "Milage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F);
            this.label6.Location = new System.Drawing.Point(32, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F);
            this.label5.Location = new System.Drawing.Point(32, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F);
            this.label4.Location = new System.Drawing.Point(32, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F);
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Make:";
            // 
            // pnlRetunCar
            // 
            this.pnlRetunCar.Controls.Add(this.groupBoxReturnCar);
            this.pnlRetunCar.Location = new System.Drawing.Point(3, 182);
            this.pnlRetunCar.Name = "pnlRetunCar";
            this.pnlRetunCar.Size = new System.Drawing.Size(960, 400);
            this.pnlRetunCar.TabIndex = 0;
            // 
            // groupBoxReturnCar
            // 
            this.groupBoxReturnCar.Controls.Add(this.btnReturn);
            this.groupBoxReturnCar.Controls.Add(this.listBoxReturnCars);
            this.groupBoxReturnCar.Font = new System.Drawing.Font("Arial", 30F);
            this.groupBoxReturnCar.Location = new System.Drawing.Point(9, 19);
            this.groupBoxReturnCar.Name = "groupBoxReturnCar";
            this.groupBoxReturnCar.Size = new System.Drawing.Size(934, 369);
            this.groupBoxReturnCar.TabIndex = 0;
            this.groupBoxReturnCar.TabStop = false;
            this.groupBoxReturnCar.Text = "Cars for return";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 40F);
            this.btnReturn.Location = new System.Drawing.Point(279, 196);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 146);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // listBoxReturnCars
            // 
            this.listBoxReturnCars.Font = new System.Drawing.Font("Arial", 20F);
            this.listBoxReturnCars.FormattingEnabled = true;
            this.listBoxReturnCars.ItemHeight = 32;
            this.listBoxReturnCars.Location = new System.Drawing.Point(6, 50);
            this.listBoxReturnCars.Name = "listBoxReturnCars";
            this.listBoxReturnCars.Size = new System.Drawing.Size(267, 292);
            this.listBoxReturnCars.TabIndex = 0;
            // 
            // pnlReturnThanks
            // 
            this.pnlReturnThanks.Controls.Add(this.label9);
            this.pnlReturnThanks.Location = new System.Drawing.Point(6, 185);
            this.pnlReturnThanks.Name = "pnlReturnThanks";
            this.pnlReturnThanks.Size = new System.Drawing.Size(951, 388);
            this.pnlReturnThanks.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 50F);
            this.label9.Location = new System.Drawing.Point(42, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(895, 75);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thank you for your business!";
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Font = new System.Drawing.Font("Arial", 20F);
            this.btnReturnCar.Location = new System.Drawing.Point(298, 73);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(116, 97);
            this.btnReturnCar.TabIndex = 2;
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 16F);
            this.txtLastName.Location = new System.Drawing.Point(556, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 32);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 16F);
            this.txtFirstName.Location = new System.Drawing.Point(556, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 32);
            this.txtFirstName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 24F);
            this.label10.Location = new System.Drawing.Point(355, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 36);
            this.label10.TabIndex = 2;
            this.label10.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F);
            this.label8.Location = new System.Drawing.Point(352, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F);
            this.label1.Location = new System.Drawing.Point(352, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your booking info:";
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Font = new System.Drawing.Font("Arial", 20F);
            this.btnShowCustomers.Location = new System.Drawing.Point(438, 73);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(116, 97);
            this.btnShowCustomers.TabIndex = 5;
            this.btnShowCustomers.Text = "Show Cust..";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // pnlShowCustomers
            // 
            this.pnlShowCustomers.Controls.Add(this.listBoxCustomers);
            this.pnlShowCustomers.Location = new System.Drawing.Point(2, 188);
            this.pnlShowCustomers.Name = "pnlShowCustomers";
            this.pnlShowCustomers.Size = new System.Drawing.Size(964, 397);
            this.pnlShowCustomers.TabIndex = 6;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Arial", 24F);
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 36;
            this.listBoxCustomers.Location = new System.Drawing.Point(13, 13);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(939, 364);
            this.listBoxCustomers.TabIndex = 0;
            // 
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 610);
            this.Controls.Add(this.pnlAvailableCars);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlShowCustomers);
            this.Controls.Add(this.pnlThankYouBooking);
            this.Controls.Add(this.pnlReturnThanks);
            this.Controls.Add(this.pnlRetunCar);
            this.Controls.Add(this.lblCountCars);
            this.Controls.Add(this.btnShowAvailableCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnShowCustomers);
            this.Name = "CarRental";
            this.Text = "CarRental";
            this.pnlAvailableCars.ResumeLayout(false);
            this.groupBoxAvailableCars.ResumeLayout(false);
            this.groupBoxAvailableCars.PerformLayout();
            this.pnlThankYouBooking.ResumeLayout(false);
            this.pnlThankYouBooking.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.groupBoxAddCar.ResumeLayout(false);
            this.groupBoxAddCar.PerformLayout();
            this.pnlRetunCar.ResumeLayout(false);
            this.groupBoxReturnCar.ResumeLayout(false);
            this.pnlReturnThanks.ResumeLayout(false);
            this.pnlReturnThanks.PerformLayout();
            this.pnlShowCustomers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAvailableCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblCountCars;
        private System.Windows.Forms.Panel pnlAvailableCars;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.Panel pnlRetunCar;
        private System.Windows.Forms.Panel pnlThankYouBooking;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxAvailableCars;
        private System.Windows.Forms.Button btnBookCar;
        private System.Windows.Forms.ListBox listBoxAvailableCars;
        private System.Windows.Forms.GroupBox groupBoxAddCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.GroupBox groupBoxReturnCar;
        private System.Windows.Forms.Panel pnlReturnThanks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox listBoxReturnCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Panel pnlShowCustomers;
        private System.Windows.Forms.ListBox listBoxCustomers;
    }
}

