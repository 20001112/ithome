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
    public partial class Guess : Form
    {
        private int answer;
        public 考試_Guess guessForm;
        public int min=1;
        public int max=100;




        public Guess()
        {
            InitializeComponent();
        }

        public Guess(考試_Guess guessForm,int answer)
        {
            this.guessForm = guessForm; // 設定 guessForm 屬性為考試_Guess 表單的實例
            this.answer = answer;
            InitializeComponent();
        }

        public void Btn_Enter_Click(object sender, EventArgs e)
        {
            int guess;

            if (!int.TryParse(txt_Guess.Text, out guess))
            {
                MessageBox.Show("請輸入有效的數字");
                return;
            }
            else {
                if (Guesss.Max < guess || guess < Guesss.Min)
                {
                    MessageBox.Show($"請輸入範圍值{Guesss.Max}跟{Guesss.Min}範圍內的值");
                }

                
                if (answer == guess)
                {
                    Guesss.Min = 1;
                    Guesss.Max = 100;
                    guessForm.UpdateLabels();
                    MessageBox.Show($"恭喜妳答對了 答案是{answer}");
                }
                else if (answer > guess && guess > 1)
                {
                    Guesss.Min = guess;
                    guessForm.UpdateLabels();
                    MessageBox.Show($"比較小{Guesss.Min}");



                }
                else if (answer < guess && guess <100)
                {
                    Guesss.Max = guess;
                    guessForm.UpdateLabels();
                    MessageBox.Show($"比較大{Guesss.Max}");




                }
            }
        }   
    }
}
