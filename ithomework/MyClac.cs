using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ithomework
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }
        decimal X;
        decimal Y;


        private void Btn_add_Click(object sender, EventArgs e)
        {   

            if (!decimal.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else if (!decimal.TryParse(textBox2.Text,out Y))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else
            {
                X = decimal.Parse(textBox1.Text);
                Y = decimal.Parse(textBox2.Text);
                txt_Answer.Text = $"{X + Y}";

            }

        }

        private void Btn_reduce_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else if (!decimal.TryParse(textBox2.Text, out Y))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else
            {
                X = decimal.Parse(textBox1.Text);
                Y = decimal.Parse(textBox2.Text);
                txt_Answer.Text = $"{X - Y}";

            }
        }

        private void Btn_take_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            if (!decimal.TryParse(textBox2.Text, out Y))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else
            {
                X = decimal.Parse(textBox1.Text);
                Y = decimal.Parse(textBox2.Text);
                txt_Answer.Text = $"{X * Y}";
            }

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(textBox1.Text, out X))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else if (!decimal.TryParse(textBox2.Text, out Y))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else if(Y==0)
            {
                MessageBox.Show("請輸入有效的分母");

            }
            else
            {
                X = decimal.Parse(textBox1.Text);
                Y = decimal.Parse(textBox2.Text);
                txt_Answer.Text = $"{X / Y}";
            }

        }
    }
}
