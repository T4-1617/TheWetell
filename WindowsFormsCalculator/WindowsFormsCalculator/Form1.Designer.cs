namespace WindowsFormsCalculator
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonTimes = new System.Windows.Forms.Button();
            this.ButtonSplit = new System.Windows.Forms.Button();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(124, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 25);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ButtonAdd";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(124, 33);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 25);
            this.ButtonMinus.TabIndex = 3;
            this.ButtonMinus.Text = "ButtonMinus";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonTimes
            // 
            this.ButtonTimes.Location = new System.Drawing.Point(124, 62);
            this.ButtonTimes.Name = "ButtonTimes";
            this.ButtonTimes.Size = new System.Drawing.Size(75, 25);
            this.ButtonTimes.TabIndex = 4;
            this.ButtonTimes.Text = "ButtonTimes";
            this.ButtonTimes.UseVisualStyleBackColor = true;
            this.ButtonTimes.Click += new System.EventHandler(this.ButtonTimes_Click);
            // 
            // ButtonSplit
            // 
            this.ButtonSplit.Location = new System.Drawing.Point(124, 91);
            this.ButtonSplit.Name = "ButtonSplit";
            this.ButtonSplit.Size = new System.Drawing.Size(75, 25);
            this.ButtonSplit.TabIndex = 5;
            this.ButtonSplit.Text = "ButtonSplit";
            this.ButtonSplit.UseVisualStyleBackColor = true;
            this.ButtonSplit.Click += new System.EventHandler(this.ButtonSplit_Click);
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.Location = new System.Drawing.Point(82, 122);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(159, 23);
            this.ButtonCalc.TabIndex = 6;
            this.ButtonCalc.Text = "ButtonCalc";
            this.ButtonCalc.UseVisualStyleBackColor = true;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 279);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.ButtonSplit);
            this.Controls.Add(this.ButtonTimes);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonTimes;
        private System.Windows.Forms.Button ButtonSplit;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.ListBox listBox1;
    }
}

