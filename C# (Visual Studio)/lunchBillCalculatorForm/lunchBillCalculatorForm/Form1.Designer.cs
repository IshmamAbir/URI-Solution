namespace lunchBillCalculatorForm
{
    partial class Lunch
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
            this.riceTextBox = new System.Windows.Forms.TextBox();
            this.fishTextBox = new System.Windows.Forms.TextBox();
            this.showGrossTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.meatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalShowButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.netBillShowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // riceTextBox
            // 
            this.riceTextBox.Location = new System.Drawing.Point(264, 30);
            this.riceTextBox.Name = "riceTextBox";
            this.riceTextBox.Size = new System.Drawing.Size(211, 20);
            this.riceTextBox.TabIndex = 0;
            // 
            // fishTextBox
            // 
            this.fishTextBox.Location = new System.Drawing.Point(264, 65);
            this.fishTextBox.Name = "fishTextBox";
            this.fishTextBox.Size = new System.Drawing.Size(211, 20);
            this.fishTextBox.TabIndex = 0;
            // 
            // showGrossTextBox
            // 
            this.showGrossTextBox.Location = new System.Drawing.Point(264, 178);
            this.showGrossTextBox.Name = "showGrossTextBox";
            this.showGrossTextBox.Size = new System.Drawing.Size(211, 20);
            this.showGrossTextBox.TabIndex = 0;
            this.showGrossTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(264, 214);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(211, 20);
            this.discountTextBox.TabIndex = 0;
            // 
            // meatTextBox
            // 
            this.meatTextBox.Location = new System.Drawing.Point(264, 101);
            this.meatTextBox.Name = "meatTextBox";
            this.meatTextBox.Size = new System.Drawing.Size(211, 20);
            this.meatTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rice (Unit price :20 tk)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fish (Unit price: 80tk)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meat (Unit price: 100tk)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Gross :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Discount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "%";
            // 
            // totalShowButton
            // 
            this.totalShowButton.Location = new System.Drawing.Point(68, 176);
            this.totalShowButton.Name = "totalShowButton";
            this.totalShowButton.Size = new System.Drawing.Size(105, 23);
            this.totalShowButton.TabIndex = 3;
            this.totalShowButton.Text = "Show Total";
            this.totalShowButton.UseVisualStyleBackColor = true;
            this.totalShowButton.Click += new System.EventHandler(this.totalShowButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "VAT(5%)";
            // 
            // netBillShowButton
            // 
            this.netBillShowButton.Location = new System.Drawing.Point(264, 290);
            this.netBillShowButton.Name = "netBillShowButton";
            this.netBillShowButton.Size = new System.Drawing.Size(211, 38);
            this.netBillShowButton.TabIndex = 3;
            this.netBillShowButton.Text = "Show Net Bill";
            this.netBillShowButton.UseVisualStyleBackColor = true;
            this.netBillShowButton.Click += new System.EventHandler(this.netBillShowButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.netBillShowButton);
            this.groupBox1.Controls.Add(this.totalShowButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(this.meatTextBox);
            this.groupBox1.Controls.Add(this.showGrossTextBox);
            this.groupBox1.Controls.Add(this.fishTextBox);
            this.groupBox1.Controls.Add(this.riceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill For Lunch";
            // 
            // Lunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch BIll Calculator";
            this.Load += new System.EventHandler(this.Lunch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox riceTextBox;
        private System.Windows.Forms.TextBox fishTextBox;
        private System.Windows.Forms.TextBox showGrossTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox meatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button totalShowButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button netBillShowButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

