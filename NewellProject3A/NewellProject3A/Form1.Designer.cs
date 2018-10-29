namespace NewellProject3A
{
    partial class frmYTDCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTDCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYTDPmt = new System.Windows.Forms.TextBox();
            this.txtYTDIntRate = new System.Windows.Forms.TextBox();
            this.txtYTDNoPmts = new System.Windows.Forms.TextBox();
            this.txtYTDTotlPd = new System.Windows.Forms.TextBox();
            this.txtYTDTotlIntPd = new System.Windows.Forms.TextBox();
            this.txtYTDTotlPrinPd = new System.Windows.Forms.TextBox();
            this.btnCalcYTD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year-To-Date Analysis Calculation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Monthly Payment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interest Rate:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Payments:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Amount Paid:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Interest Paid:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Principal Paid:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYTDPmt
            // 
            this.txtYTDPmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDPmt.Location = new System.Drawing.Point(278, 198);
            this.txtYTDPmt.Name = "txtYTDPmt";
            this.txtYTDPmt.Size = new System.Drawing.Size(139, 24);
            this.txtYTDPmt.TabIndex = 1;
            // 
            // txtYTDIntRate
            // 
            this.txtYTDIntRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDIntRate.Location = new System.Drawing.Point(278, 245);
            this.txtYTDIntRate.Name = "txtYTDIntRate";
            this.txtYTDIntRate.Size = new System.Drawing.Size(139, 24);
            this.txtYTDIntRate.TabIndex = 2;
            // 
            // txtYTDNoPmts
            // 
            this.txtYTDNoPmts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDNoPmts.Location = new System.Drawing.Point(278, 294);
            this.txtYTDNoPmts.Name = "txtYTDNoPmts";
            this.txtYTDNoPmts.Size = new System.Drawing.Size(139, 24);
            this.txtYTDNoPmts.TabIndex = 3;
            // 
            // txtYTDTotlPd
            // 
            this.txtYTDTotlPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlPd.Location = new System.Drawing.Point(630, 198);
            this.txtYTDTotlPd.Name = "txtYTDTotlPd";
            this.txtYTDTotlPd.ReadOnly = true;
            this.txtYTDTotlPd.Size = new System.Drawing.Size(137, 24);
            this.txtYTDTotlPd.TabIndex = 6;
            this.txtYTDTotlPd.TabStop = false;
            // 
            // txtYTDTotlIntPd
            // 
            this.txtYTDTotlIntPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlIntPd.Location = new System.Drawing.Point(630, 245);
            this.txtYTDTotlIntPd.Name = "txtYTDTotlIntPd";
            this.txtYTDTotlIntPd.ReadOnly = true;
            this.txtYTDTotlIntPd.Size = new System.Drawing.Size(137, 24);
            this.txtYTDTotlIntPd.TabIndex = 7;
            this.txtYTDTotlIntPd.TabStop = false;
            // 
            // txtYTDTotlPrinPd
            // 
            this.txtYTDTotlPrinPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlPrinPd.Location = new System.Drawing.Point(630, 294);
            this.txtYTDTotlPrinPd.Name = "txtYTDTotlPrinPd";
            this.txtYTDTotlPrinPd.ReadOnly = true;
            this.txtYTDTotlPrinPd.Size = new System.Drawing.Size(137, 24);
            this.txtYTDTotlPrinPd.TabIndex = 8;
            this.txtYTDTotlPrinPd.TabStop = false;
            // 
            // btnCalcYTD
            // 
            this.btnCalcYTD.Location = new System.Drawing.Point(209, 365);
            this.btnCalcYTD.Name = "btnCalcYTD";
            this.btnCalcYTD.Size = new System.Drawing.Size(144, 38);
            this.btnCalcYTD.TabIndex = 4;
            this.btnCalcYTD.Text = "&Calculate";
            this.btnCalcYTD.UseVisualStyleBackColor = true;
            this.btnCalcYTD.Click += new System.EventHandler(this.btnCalcYTD_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(508, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmYTDCalc
            // 
            this.AcceptButton = this.btnCalcYTD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(845, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcYTD);
            this.Controls.Add(this.txtYTDTotlPrinPd);
            this.Controls.Add(this.txtYTDTotlIntPd);
            this.Controls.Add(this.txtYTDTotlPd);
            this.Controls.Add(this.txtYTDNoPmts);
            this.Controls.Add(this.txtYTDIntRate);
            this.Controls.Add(this.txtYTDPmt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmYTDCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year-To-Date Payment Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYTDPmt;
        private System.Windows.Forms.TextBox txtYTDIntRate;
        private System.Windows.Forms.TextBox txtYTDNoPmts;
        private System.Windows.Forms.TextBox txtYTDTotlPd;
        private System.Windows.Forms.TextBox txtYTDTotlIntPd;
        private System.Windows.Forms.TextBox txtYTDTotlPrinPd;
        private System.Windows.Forms.Button btnCalcYTD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

