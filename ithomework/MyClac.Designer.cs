namespace ithomework
{
    partial class MyClac
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
            this.Btn_add = new System.Windows.Forms.Button();
            this.Btn_reduce = new System.Windows.Forms.Button();
            this.Btn_take = new System.Windows.Forms.Button();
            this.Btn_remove = new System.Windows.Forms.Button();
            this.NUM1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_add
            // 
            this.Btn_add.Location = new System.Drawing.Point(469, 61);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(74, 47);
            this.Btn_add.TabIndex = 0;
            this.Btn_add.Text = "+";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_reduce
            // 
            this.Btn_reduce.Location = new System.Drawing.Point(469, 136);
            this.Btn_reduce.Name = "Btn_reduce";
            this.Btn_reduce.Size = new System.Drawing.Size(74, 47);
            this.Btn_reduce.TabIndex = 1;
            this.Btn_reduce.Text = "-";
            this.Btn_reduce.UseVisualStyleBackColor = true;
            this.Btn_reduce.Click += new System.EventHandler(this.Btn_reduce_Click);
            // 
            // Btn_take
            // 
            this.Btn_take.Location = new System.Drawing.Point(469, 222);
            this.Btn_take.Name = "Btn_take";
            this.Btn_take.Size = new System.Drawing.Size(74, 47);
            this.Btn_take.TabIndex = 2;
            this.Btn_take.Text = "*";
            this.Btn_take.UseVisualStyleBackColor = true;
            this.Btn_take.Click += new System.EventHandler(this.Btn_take_Click);
            // 
            // Btn_remove
            // 
            this.Btn_remove.Location = new System.Drawing.Point(469, 308);
            this.Btn_remove.Name = "Btn_remove";
            this.Btn_remove.Size = new System.Drawing.Size(74, 47);
            this.Btn_remove.TabIndex = 3;
            this.Btn_remove.Text = "/";
            this.Btn_remove.UseVisualStyleBackColor = true;
            this.Btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // NUM1
            // 
            this.NUM1.AutoSize = true;
            this.NUM1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUM1.Location = new System.Drawing.Point(60, 70);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(70, 24);
            this.NUM1.TabIndex = 4;
            this.NUM1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "=================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "ANSWER";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Enabled = false;
            this.txt_Answer.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Answer.Location = new System.Drawing.Point(162, 307);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(100, 33);
            this.txt_Answer.TabIndex = 12;
            // 
            // MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.Btn_remove);
            this.Controls.Add(this.Btn_take);
            this.Controls.Add(this.Btn_reduce);
            this.Controls.Add(this.Btn_add);
            this.Name = "MyClac";
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Btn_reduce;
        private System.Windows.Forms.Button Btn_take;
        private System.Windows.Forms.Button Btn_remove;
        private System.Windows.Forms.Label NUM1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Answer;
    }
}