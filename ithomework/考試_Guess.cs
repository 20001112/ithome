using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ithomework.Unity;

namespace ithomework
{
    public static class Guesss
    {
        public static int Min=1;
        public static int Max=100;
    }
    public partial class 考試_Guess : Form
    {


        public 考試_Guess()
        {
            InitializeComponent();


        }
        private int max;
        private int min;
        public string hundred;
        public string one;





        public void UpdateLabels()
        {
            Lab_hundred.Text = Guesss.Max.ToString();
            Lab_one.Text = Guesss.Min.ToString();
        }
        public int answer = 0;
        public Random random = new Random();
        private int guess;

        public void Btn_ShowAnswer_Click(object sender, EventArgs e)
        {
            if (answer==0)
            {
                answer = random.Next(1, 100);
            }
            Guess guess = new Guess(this, answer); // 傳遞考試_Guess 表單的實例給 Guess 表單
            guess.ShowDialog();
        }

        public void Btn_Guess_Click(object sender, EventArgs e)
        {
            if(answer==0)
            {
              answer = random.Next(1, 100);

            }
            MessageBox.Show($"答案是{answer}");

            answer = random.Next(1, 100);


        }
        

    }
}
