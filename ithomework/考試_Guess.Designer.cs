namespace ithomework
{
    partial class 考試_Guess
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
            this.Btn_Guess = new System.Windows.Forms.Button();
            this.Btn_ShowAnswer = new System.Windows.Forms.Button();
            this.Lab_one = new System.Windows.Forms.Label();
            this.Lab_hundred = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(88, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLEASE SELECT A NUMBER BEWTEEN           TO ";
            // 
            // Btn_Guess
            // 
            this.Btn_Guess.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Guess.Location = new System.Drawing.Point(483, 238);
            this.Btn_Guess.Name = "Btn_Guess";
            this.Btn_Guess.Size = new System.Drawing.Size(204, 69);
            this.Btn_Guess.TabIndex = 2;
            this.Btn_Guess.Text = "ShowAnswer";
            this.Btn_Guess.UseVisualStyleBackColor = true;
            this.Btn_Guess.Click += new System.EventHandler(this.Btn_Guess_Click);
            // 
            // Btn_ShowAnswer
            // 
            this.Btn_ShowAnswer.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ShowAnswer.Location = new System.Drawing.Point(92, 238);
            this.Btn_ShowAnswer.Name = "Btn_ShowAnswer";
            this.Btn_ShowAnswer.Size = new System.Drawing.Size(204, 69);
            this.Btn_ShowAnswer.TabIndex = 3;
            this.Btn_ShowAnswer.Text = "Guess";
            this.Btn_ShowAnswer.UseVisualStyleBackColor = true;
            this.Btn_ShowAnswer.Click += new System.EventHandler(this.Btn_ShowAnswer_Click);
            // 
            // Lab_one
            // 
            this.Lab_one.AutoSize = true;
            this.Lab_one.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_one.Location = new System.Drawing.Point(566, 123);
            this.Lab_one.Name = "Lab_one";
            this.Lab_one.Size = new System.Drawing.Size(22, 24);
            this.Lab_one.TabIndex = 4;
            this.Lab_one.Text = "1";
            // 
            // Lab_hundred
            // 
            this.Lab_hundred.AutoSize = true;
            this.Lab_hundred.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_hundred.Location = new System.Drawing.Point(674, 123);
            this.Lab_hundred.Name = "Lab_hundred";
            this.Lab_hundred.Size = new System.Drawing.Size(46, 24);
            this.Lab_hundred.TabIndex = 5;
            this.Lab_hundred.Text = "100";
            // 
            // 考試_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 532);
            this.Controls.Add(this.Lab_hundred);
            this.Controls.Add(this.Lab_one);
            this.Controls.Add(this.Btn_ShowAnswer);
            this.Controls.Add(this.Btn_Guess);
            this.Controls.Add(this.label1);
            this.Name = "考試_Guess";
            this.Text = "考試_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Guess;
        private System.Windows.Forms.Button Btn_ShowAnswer;
        public System.Windows.Forms.Label Lab_one;
        public System.Windows.Forms.Label Lab_hundred;
    }
}