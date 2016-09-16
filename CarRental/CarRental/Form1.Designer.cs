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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAvailableCars = new System.Windows.Forms.Panel();
            this.groupBoxAvailableCars = new System.Windows.Forms.GroupBox();
            this.btnBookCar = new System.Windows.Forms.Button();
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.pnlThankYouBooking = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxAddCar = new System.Windows.Forms.GroupBox();
            this.txtHired = new System.Windows.Forms.TextBox();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pnlAvailableCars.SuspendLayout();
            this.groupBoxAvailableCars.SuspendLayout();
            this.pnlThankYouBooking.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.groupBoxAddCar.SuspendLayout();
            this.pnlRetunCar.SuspendLayout();
            this.groupBoxReturnCar.SuspendLayout();
            this.pnlReturnThanks.SuspendLayout();
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
            this.btnAddCar.Location = new System.Drawing.Point(157, 73);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(116, 97);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "We have 3 cars available";
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
            this.groupBoxAvailableCars.Controls.Add(this.listBoxAvailableCars);
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
            this.pnlAddCar.Location = new System.Drawing.Point(9, 182);
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
            // 
            // groupBoxAddCar
            // 
            this.groupBoxAddCar.Controls.Add(this.txtHired);
            this.groupBoxAddCar.Controls.Add(this.txtMilage);
            this.groupBoxAddCar.Controls.Add(this.txtSeats);
            this.groupBoxAddCar.Controls.Add(this.txtColour);
            this.groupBoxAddCar.Controls.Add(this.txtModel);
            this.groupBoxAddCar.Controls.Add(this.txtMake);
            this.groupBoxAddCar.Controls.Add(this.label8);
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
            // txtHired
            // 
            this.txtHired.Font = new System.Drawing.Font("Arial", 15F);
            this.txtHired.Location = new System.Drawing.Point(184, 286);
            this.txtHired.Name = "txtHired";
            this.txtHired.Size = new System.Drawing.Size(143, 30);
            this.txtHired.TabIndex = 11;
            // 
            // txtMilage
            // 
            this.txtMilage.Font = new System.Drawing.Font("Arial", 15F);
            this.txtMilage.Location = new System.Drawing.Point(184, 244);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(143, 30);
            this.txtMilage.TabIndex = 10;
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSeats.Location = new System.Drawing.Point(186, 202);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(143, 30);
            this.txtSeats.TabIndex = 9;
            // 
            // txtColour
            // 
            this.txtColour.Font = new System.Drawing.Font("Arial", 15F);
            this.txtColour.Location = new System.Drawing.Point(184, 160);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(143, 30);
            this.txtColour.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 15F);
            this.txtModel.Location = new System.Drawing.Point(184, 117);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(143, 30);
            this.txtModel.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Arial", 15F);
            this.txtMake.Location = new System.Drawing.Point(184, 76);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(143, 30);
            this.txtMake.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F);
            this.label8.Location = new System.Drawing.Point(47, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 36);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hired:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F);
            this.label7.Location = new System.Drawing.Point(47, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "Milage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F);
            this.label6.Location = new System.Drawing.Point(47, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F);
            this.label5.Location = new System.Drawing.Point(47, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F);
            this.label4.Location = new System.Drawing.Point(47, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F);
            this.label3.Location = new System.Drawing.Point(47, 69);
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
            this.btnReturnCar.Location = new System.Drawing.Point(302, 73);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(116, 97);
            this.btnReturnCar.TabIndex = 2;
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 607);
            this.Controls.Add(this.pnlAvailableCars);
            this.Controls.Add(this.pnlThankYouBooking);
            this.Controls.Add(this.pnlReturnThanks);
            this.Controls.Add(this.pnlRetunCar);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAvailableCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnReturnCar);
            this.Name = "CarRental";
            this.Text = "CarRental";
            this.pnlAvailableCars.ResumeLayout(false);
            this.groupBoxAvailableCars.ResumeLayout(false);
            this.pnlThankYouBooking.ResumeLayout(false);
            this.pnlThankYouBooking.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.groupBoxAddCar.ResumeLayout(false);
            this.groupBoxAddCar.PerformLayout();
            this.pnlRetunCar.ResumeLayout(false);
            this.groupBoxReturnCar.ResumeLayout(false);
            this.pnlReturnThanks.ResumeLayout(false);
            this.pnlReturnThanks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAvailableCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtHired;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxReturnCar;
        private System.Windows.Forms.Panel pnlReturnThanks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox listBoxReturnCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturnCar;
    }
}

