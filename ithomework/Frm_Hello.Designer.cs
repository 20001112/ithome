namespace ithomework
{
    partial class Frm_Hello
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.BtnSayHI = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.LabEnglishName = new System.Windows.Forms.Label();
            this.LabGender = new System.Windows.Forms.Label();
            this.LabConstellation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(192, 133);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(100, 22);
            this.txtEnglishName.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(192, 203);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 2;
            // 
            // txtConstellation
            // 
            this.txtConstellation.Location = new System.Drawing.Point(192, 270);
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(100, 22);
            this.txtConstellation.TabIndex = 3;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(76, 348);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(75, 23);
            this.btnSayHello.TabIndex = 4;
            this.btnSayHello.Text = "SayHello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // BtnSayHI
            // 
            this.BtnSayHI.Location = new System.Drawing.Point(217, 348);
            this.BtnSayHI.Name = "BtnSayHI";
            this.BtnSayHI.Size = new System.Drawing.Size(75, 23);
            this.BtnSayHI.TabIndex = 5;
            this.BtnSayHI.Text = "SayHI!";
            this.BtnSayHI.UseVisualStyleBackColor = true;
            this.BtnSayHI.Click += new System.EventHandler(this.BtnSayHI_Click_1);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabName.Location = new System.Drawing.Point(61, 79);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(52, 19);
            this.LabName.TabIndex = 6;
            this.LabName.Text = "姓名:";
            // 
            // LabEnglishName
            // 
            this.LabEnglishName.AutoSize = true;
            this.LabEnglishName.BackColor = System.Drawing.Color.Transparent;
            this.LabEnglishName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabEnglishName.Location = new System.Drawing.Point(61, 136);
            this.LabEnglishName.Name = "LabEnglishName";
            this.LabEnglishName.Size = new System.Drawing.Size(107, 19);
            this.LabEnglishName.TabIndex = 7;
            this.LabEnglishName.Text = "EnglishName";
            // 
            // LabGender
            // 
            this.LabGender.AutoSize = true;
            this.LabGender.BackColor = System.Drawing.Color.Transparent;
            this.LabGender.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabGender.Location = new System.Drawing.Point(61, 206);
            this.LabGender.Name = "LabGender";
            this.LabGender.Size = new System.Drawing.Size(47, 19);
            this.LabGender.TabIndex = 8;
            this.LabGender.Text = "性別";
            // 
            // LabConstellation
            // 
            this.LabConstellation.AutoSize = true;
            this.LabConstellation.BackColor = System.Drawing.Color.Transparent;
            this.LabConstellation.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabConstellation.Location = new System.Drawing.Point(61, 273);
            this.LabConstellation.Name = "LabConstellation";
            this.LabConstellation.Size = new System.Drawing.Size(47, 19);
            this.LabConstellation.TabIndex = 9;
            this.LabConstellation.Text = "星座";
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ithomework.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 516);
            this.Controls.Add(this.LabConstellation);
            this.Controls.Add(this.LabGender);
            this.Controls.Add(this.LabEnglishName);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.BtnSayHI);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.txtConstellation);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtName);
            this.Name = "Frm_Hello";
            this.Text = "Frm_Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtConstellation;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button BtnSayHI;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label LabEnglishName;
        private System.Windows.Forms.Label LabGender;
        private System.Windows.Forms.Label LabConstellation;
    }
}