namespace ithomework
{
    partial class Frm_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Loan));
            this.Lab_Year = new System.Windows.Forms.Label();
            this.Lab_interest = new System.Windows.Forms.Label();
            this.Lab_Head = new System.Windows.Forms.Label();
            this.Lab_Loan = new System.Windows.Forms.Label();
            this.Btn_PMT = new System.Windows.Forms.Button();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.txt_Loan = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Head = new System.Windows.Forms.TextBox();
            this.txt_interest = new System.Windows.Forms.TextBox();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Year
            // 
            this.Lab_Year.AutoSize = true;
            this.Lab_Year.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Year.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Year.Location = new System.Drawing.Point(44, 178);
            this.Lab_Year.Name = "Lab_Year";
            this.Lab_Year.Size = new System.Drawing.Size(78, 19);
            this.Lab_Year.TabIndex = 7;
            this.Lab_Year.Text = "期限(年)";
            // 
            // Lab_interest
            // 
            this.Lab_interest.AutoSize = true;
            this.Lab_interest.BackColor = System.Drawing.Color.Transparent;
            this.Lab_interest.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_interest.Location = new System.Drawing.Point(44, 247);
            this.Lab_interest.Name = "Lab_interest";
            this.Lab_interest.Size = new System.Drawing.Size(47, 19);
            this.Lab_interest.TabIndex = 8;
            this.Lab_interest.Text = "利率";
            // 
            // Lab_Head
            // 
            this.Lab_Head.AutoSize = true;
            this.Lab_Head.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Head.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Head.Location = new System.Drawing.Point(44, 311);
            this.Lab_Head.Name = "Lab_Head";
            this.Lab_Head.Size = new System.Drawing.Size(66, 19);
            this.Lab_Head.TabIndex = 9;
            this.Lab_Head.Text = "頭期款";
            // 
            // Lab_Loan
            // 
            this.Lab_Loan.AutoSize = true;
            this.Lab_Loan.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Loan.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Loan.Location = new System.Drawing.Point(44, 110);
            this.Lab_Loan.Name = "Lab_Loan";
            this.Lab_Loan.Size = new System.Drawing.Size(85, 19);
            this.Lab_Loan.TabIndex = 10;
            this.Lab_Loan.Text = "貸款金額";
            // 
            // Btn_PMT
            // 
            this.Btn_PMT.Location = new System.Drawing.Point(23, 412);
            this.Btn_PMT.Name = "Btn_PMT";
            this.Btn_PMT.Size = new System.Drawing.Size(106, 38);
            this.Btn_PMT.TabIndex = 11;
            this.Btn_PMT.Text = "PMT(月付)";
            this.Btn_PMT.UseVisualStyleBackColor = true;
            this.Btn_PMT.Click += new System.EventHandler(this.Btn_PMT_Click);
            // 
            // Btn_Total
            // 
            this.Btn_Total.Location = new System.Drawing.Point(198, 412);
            this.Btn_Total.Name = "Btn_Total";
            this.Btn_Total.Size = new System.Drawing.Size(106, 38);
            this.Btn_Total.TabIndex = 12;
            this.Btn_Total.Text = "總付款";
            this.Btn_Total.UseVisualStyleBackColor = true;
            this.Btn_Total.Click += new System.EventHandler(this.Btn_Total_Click);
            // 
            // txt_Loan
            // 
            this.txt_Loan.Location = new System.Drawing.Point(204, 107);
            this.txt_Loan.Name = "txt_Loan";
            this.txt_Loan.Size = new System.Drawing.Size(100, 22);
            this.txt_Loan.TabIndex = 13;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(204, 178);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 22);
            this.txt_Year.TabIndex = 14;
            // 
            // txt_Head
            // 
            this.txt_Head.Location = new System.Drawing.Point(204, 308);
            this.txt_Head.Name = "txt_Head";
            this.txt_Head.Size = new System.Drawing.Size(100, 22);
            this.txt_Head.TabIndex = 15;
            // 
            // txt_interest
            // 
            this.txt_interest.Location = new System.Drawing.Point(204, 249);
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.Size = new System.Drawing.Size(100, 22);
            this.txt_interest.TabIndex = 16;
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(398, 412);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(106, 38);
            this.Btn_Report.TabIndex = 17;
            this.Btn_Report.Text = "Report";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 631);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.txt_interest);
            this.Controls.Add(this.txt_Head);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Loan);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Btn_PMT);
            this.Controls.Add(this.Lab_Loan);
            this.Controls.Add(this.Lab_Head);
            this.Controls.Add(this.Lab_interest);
            this.Controls.Add(this.Lab_Year);
            this.Name = "Frm_Loan";
            this.Text = "Frm_Loan";
            this.Load += new System.EventHandler(this.Frm_Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Year;
        private System.Windows.Forms.Label Lab_interest;
        private System.Windows.Forms.Label Lab_Head;
        private System.Windows.Forms.Label Lab_Loan;
        private System.Windows.Forms.Button Btn_PMT;
        private System.Windows.Forms.Button Btn_Total;
        private System.Windows.Forms.TextBox txt_Loan;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Head;
        private System.Windows.Forms.TextBox txt_interest;
        private System.Windows.Forms.Button Btn_Report;
    }
}