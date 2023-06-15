namespace ithomework
{
    partial class Guess
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
            this.Btn_Canel = new System.Windows.Forms.Button();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Guess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Canel
            // 
            this.Btn_Canel.Location = new System.Drawing.Point(447, 220);
            this.Btn_Canel.Name = "Btn_Canel";
            this.Btn_Canel.Size = new System.Drawing.Size(150, 49);
            this.Btn_Canel.TabIndex = 0;
            this.Btn_Canel.Text = "Canel";
            this.Btn_Canel.UseVisualStyleBackColor = true;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Location = new System.Drawing.Point(447, 108);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(150, 49);
            this.Btn_Enter.TabIndex = 1;
            this.Btn_Enter.Text = "ENTER";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(109, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLEASE INPUT A NUMBER";
            // 
            // txt_Guess
            // 
            this.txt_Guess.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Guess.Location = new System.Drawing.Point(154, 230);
            this.txt_Guess.Name = "txt_Guess";
            this.txt_Guess.Size = new System.Drawing.Size(188, 30);
            this.txt_Guess.TabIndex = 3;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 315);
            this.Controls.Add(this.txt_Guess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.Btn_Canel);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Canel;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Guess;
    }
}