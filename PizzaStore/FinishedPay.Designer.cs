namespace PizzaStore
{
    partial class FinishedPay
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
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gift = new System.Windows.Forms.RadioButton();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.totalprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.TextBox();
            this.Finished = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(274, 219);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gift);
            this.groupBox1.Controls.Add(this.Cash);
            this.groupBox1.Controls.Add(this.Card);
            this.groupBox1.Controls.Add(this.totalprice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Tender";
            // 
            // Gift
            // 
            this.Gift.AutoSize = true;
            this.Gift.Location = new System.Drawing.Point(22, 96);
            this.Gift.Name = "Gift";
            this.Gift.Size = new System.Drawing.Size(41, 17);
            this.Gift.TabIndex = 6;
            this.Gift.TabStop = true;
            this.Gift.Text = "Gift";
            this.Gift.UseVisualStyleBackColor = true;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(22, 62);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(49, 17);
            this.Cash.TabIndex = 6;
            this.Cash.TabStop = true;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(22, 30);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(77, 17);
            this.Card.TabIndex = 6;
            this.Card.TabStop = true;
            this.Card.Text = "Credit Card";
            this.Card.UseVisualStyleBackColor = true;
            // 
            // totalprice
            // 
            this.totalprice.Location = new System.Drawing.Point(77, 139);
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Size = new System.Drawing.Size(100, 20);
            this.totalprice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Payment:  ";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(274, 41);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 20);
            this.change.TabIndex = 10;
            // 
            // Finished
            // 
            this.Finished.Location = new System.Drawing.Point(274, 70);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(100, 41);
            this.Finished.TabIndex = 11;
            this.Finished.Text = "Tender";
            this.Finished.UseVisualStyleBackColor = true;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(12, 219);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(99, 41);
            this.GoBack.TabIndex = 13;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // FinishedPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 281);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Finished);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Name = "FinishedPay";
            this.Text = "Finshing Tender";
            this.Load += new System.EventHandler(this.FinishedPay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.RadioButton Gift;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.Button Finished;
        private System.Windows.Forms.Button GoBack;
    }
}