using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ithomework
{
    public partial class Frm_StudentsGrade : Form
    {
        public Frm_StudentsGrade()
        {
            InitializeComponent();
        }
        private int counts = 0;
        private int chineseGrade = 0;
        private int mathGrade = 0;
        private int englishGrade = 0;
        private int totalChineseGrade = 0;
        private int totalMathGrade = 0;
        private int totalEnglishGrade = 0;
        private int chineseGrademaxGrade = int.MinValue;
        private int chineseGrademinGrade = int.MaxValue;
        private int mathGrademaxGrade = int.MinValue;
        private int mathGrademinGrade = int.MaxValue;
        private int englishGrademaxGrade = int.MinValue;
        private int englishGrademinGrade = int.MaxValue;
        Dictionary<string, int> gradesDictionary = new Dictionary<string, int>();
        List<Grade> lsGrade = new List<Grade>();
         



        private void Btn_Join_Click(object sender, EventArgs e)
        { int chinesegrade ;
          int Mathgrade ;
          int Englishgrade;
         bool isChineseGrade = int.TryParse(txt_Chinese.Text, out chinesegrade);
         bool isMathGrade = int.TryParse(txt_Math.Text, out Mathgrade);
         bool isEnglishGrade = int.TryParse(txt_English.Text, out Englishgrade);


            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("請輸入姓名");
                return;
            }

        if (!isChineseGrade || !isMathGrade || !isEnglishGrade)
           {
                MessageBox.Show("請輸入有效的成績");
                return;
           }
            chineseGrade = int.Parse(txt_Chinese.Text);
            mathGrade = int.Parse(txt_Math.Text);
            englishGrade= int.Parse(txt_English.Text);



            counts++;
            totalChineseGrade += chineseGrade;
            totalMathGrade += mathGrade;
            totalEnglishGrade += englishGrade;
            

            Lab_ScoreChiese.Text += $"{chineseGrade}\n";
            Lab_ScoreMath.Text += $"{mathGrade}\n";
            Lab_ScoreEnglish.Text += $"{englishGrade}\n";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
            Lab_ScoreName.Text += $"{txt_Name.Text}\n";
            UpdateMaxAndMinGrades(chineseGrade, mathGrade, englishGrade);


            int averageTotalGrade = CalculateAverage((totalChineseGrade+totalMathGrade+ totalEnglishGrade)/3, counts);
            string count = counts.ToString();
            Lab_TotalGrade.Text += $"{(chineseGrade + mathGrade + englishGrade)}\n";
            Lab_ScoreName.Text += $"";
            Lab_AgvGrade.Text += $"{averageTotalGrade}\n";


            Grade lsMAX_MINGrade;
            lsMAX_MINGrade.Chinese = chineseGrade;
            lsMAX_MINGrade.Math = mathGrade;
            lsMAX_MINGrade.English = englishGrade;
            lsMAX_MINGrade.Name = count;
            lsGrade.Add(lsMAX_MINGrade);
            Btn_statistics.Enabled = true;
            Btn_reset.Enabled = true;






        }




        private void Btn_Random_Click(object sender, EventArgs e)
        {   
            Random random = new Random();
            int chineseGrade = random.Next(1, 100);
            int mathGrade = random.Next(1, 100);
            int englishGrade = random.Next(1, 100);// 生成一个指定范围内的整数
            counts++;
            totalChineseGrade += chineseGrade;
            totalMathGrade += mathGrade;
            totalEnglishGrade += englishGrade;
            int averageTotalGrade = CalculateAverage((totalChineseGrade + totalMathGrade + totalEnglishGrade) / 3, counts);
            string count = counts.ToString();
            Lab_ScoreChiese.Text += $"{chineseGrade}\n";
            Lab_ScoreMath.Text += $"{mathGrade}\n";
            Lab_ScoreEnglish.Text += $"{englishGrade}\n";
            Lab_ScoreName.Text += $"{count}\n";
            Lab_AgvGrade.Text += $"{averageTotalGrade}\n";
            Lab_TotalGrade.Text += $"{(chineseGrade + mathGrade + englishGrade)}\n";
            UpdateMaxAndMinGrades(chineseGrade, mathGrade, englishGrade);
            Grade lsMAX_MINGrade;
            lsMAX_MINGrade.Chinese = chineseGrade;
            lsMAX_MINGrade.Math = mathGrade;
            lsMAX_MINGrade.English = englishGrade;
            lsMAX_MINGrade.Name = count;
            lsGrade.Add(lsMAX_MINGrade);
            Btn_statistics.Enabled = true;
            Btn_reset.Enabled = true;

            //Dictionary<string, int> gradesDictionary = new Dictionary<string, int>();
            //gradesDictionary.Add("國文", chineseGrade);
            //gradesDictionary.Add("數學", mathGrade);
            //gradesDictionary.Add("英文", englishGrade);



            //Lab_AgvGrade.Text+=
            //chinesegrade = int.Parse(txt_Chinese.Text);
            //Mathgrade = int.Parse(txt_Math.Text);
            //Englishgrade = int.Parse(txt_English.Text);
        }
        private int CalculateAverage(int totalScore, int numberOfStudents)
        {
            if (numberOfStudents == 0)
                return 0;

            return (int)totalScore / numberOfStudents;
        }

        private void btn_Randomtwenty_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {

                int chineseGrade = random.Next(1, 100);
                int mathGrade = random.Next(1, 100);
                int englishGrade = random.Next(1, 100);// 生成一个指定范围内的整数
                counts++;
                totalChineseGrade += chineseGrade;
                totalMathGrade += mathGrade;
                totalEnglishGrade += englishGrade;
                int averageTotalGrade = CalculateAverage((totalChineseGrade + totalMathGrade + totalEnglishGrade) / 3, counts);
                string count = counts.ToString();
                Lab_ScoreChiese.Text += $"{chineseGrade}\n";
                Lab_ScoreMath.Text += $"{mathGrade}\n";
                Lab_ScoreEnglish.Text += $"{englishGrade}\n";
                Lab_ScoreName.Text += $"{count}\n";
                Lab_AgvGrade.Text += $"{averageTotalGrade}\n";
                Lab_TotalGrade.Text += $"{(chineseGrade + mathGrade + englishGrade)}\n";
                Btn_statistics.Enabled = true;
                UpdateMax_Min(gradesDictionary);
                Grade lsMAX_MINGrade;
                lsMAX_MINGrade.Chinese = chineseGrade;
                lsMAX_MINGrade.Math = mathGrade;
                lsMAX_MINGrade.English = englishGrade;
                lsMAX_MINGrade.Name = count;
                lsGrade.Add(lsMAX_MINGrade);


            }
            Btn_statistics.Enabled = true;




        }
        private void UpdateMaxAndMinGrades(int chineseGrade, int mathGrade, int englishGrade)
        {
            if (chineseGrade >= mathGrade && chineseGrade >= englishGrade)
            {
                Lab_MaxGrade.Text += $"國文{chineseGrade}\n";

                if (mathGrade >= englishGrade)
                {
                    Lab_MinGrade.Text += $"英文{englishGrade}\n";
                }
                else if (englishGrade >= mathGrade)
                {
                    Lab_MinGrade.Text += $"數學{mathGrade}\n";
                }
            }
            else if (mathGrade >= chineseGrade && mathGrade >= englishGrade)
            {
                Lab_MaxGrade.Text += $"數學{mathGrade}\n";

                if (chineseGrade >= englishGrade)
                {
                    Lab_MinGrade.Text += $"英文{englishGrade}\n";
                }
                else if (englishGrade >= chineseGrade)
                {
                    Lab_MinGrade.Text += $"國文{chineseGrade}\n";
                }
            }
            else if (englishGrade >= chineseGrade && englishGrade >= mathGrade)
            {
                Lab_MaxGrade.Text += $"英文{englishGrade}\n";

                if (chineseGrade >= mathGrade)
                {
                    Lab_MinGrade.Text += $"數學{mathGrade}\n";
                }
                else if (mathGrade >= chineseGrade)
                {
                    Lab_MinGrade.Text += $"國文{chineseGrade}\n";
                }

            }

        }


        private void UpdateMax_Min(Dictionary<string, int> gradesDictionary)
        {
        chineseGrademaxGrade = int.MinValue;
        chineseGrademinGrade = int.MaxValue;
        mathGrademaxGrade = int.MinValue;
        mathGrademinGrade = int.MaxValue;
        englishGrademaxGrade = int.MinValue;
        englishGrademinGrade = int.MaxValue;


            foreach (var kvp in gradesDictionary)
            {
                string subject = kvp.Key;
                int grade = kvp.Value;

                if (subject == "國文")
                {
                    if (grade > chineseGrademaxGrade)
                        chineseGrademaxGrade = grade;

                    if (grade < chineseGrademinGrade)
                        chineseGrademinGrade = grade;
                }
                else if (subject == "數學")
                {
                    if (grade > mathGrademaxGrade)
                        mathGrademaxGrade = grade;

                    if (grade < mathGrademinGrade)
                        mathGrademinGrade = grade;
                }
                else if (subject == "英文")
                {
                    if (grade > englishGrademaxGrade)
                        englishGrademaxGrade = grade;

                    if (grade < englishGrademinGrade)
                        englishGrademinGrade = grade;
                }
            }




        }

        private void Btn_statistics_Click(object sender, EventArgs e)
        {
            int AgvChineseGrade = CalculateAverage(totalChineseGrade, counts);
            int AgvMathGrade = CalculateAverage(totalMathGrade, counts);
            int AgvEnglishGrade = CalculateAverage(totalEnglishGrade, counts);
            Lab_ChineseTotalGrade2.Text = $"{totalChineseGrade}";
            Lab_MathTotalGrade2.Text = $"{totalMathGrade}";
            Lab_EnglishTotalGrade2.Text = $"{totalEnglishGrade}";
            Lab_ChineseAgvgrade2.Text = $"{AgvChineseGrade}";
            Lab_MathAgvGrade2.Text = $"{AgvMathGrade}";
            Lab_EnglishAgvGrade2.Text = $"{AgvEnglishGrade}";
            



            UpdateMax_Min(gradesDictionary);

            Lab_ChineseMaxGrade2.Text = $"最高分：\n國文 {lsGrade.Max(x=>x.Chinese)}\n";
            Lab_ChineseMinGrade2.Text = $"最低分：\n國文 {lsGrade.Min(x=>x.Chinese)}\n";
            Lab_MathMaxGrade2.Text = $"最高分：\n數學 {lsGrade.Max(x=>x.Math)}\n";
            Lab_MathMinGrade2.Text = $"最低分：\n數學 {lsGrade.Min(x=>x.Math)}\n";
            Lab_EnglishMaxGrade2.Text = $"最高分：\n英文 {lsGrade.Max(x=>x.English)}\n";
            Lab_EnglishMinGrade2.Text = $"最低分：\n英文 {lsGrade.Min(x=>x.English)}\n";
            Btn_Join.Enabled=false;
            btn_Randomtwenty.Enabled=false;
            Btn_Random.Enabled=false;
            Btn_reset.Enabled=true;

        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            counts = 0;
            Btn_Join.Enabled = true;
            btn_Randomtwenty.Enabled = true;
            Btn_Random.Enabled = true;
            lsGrade.Clear();
            Lab_ChineseMaxGrade2.Text = $"";
            Lab_ChineseMinGrade2.Text = $"";
            Lab_MathMaxGrade2.Text = $"";
            Lab_MathMinGrade2.Text = $"";
            Lab_EnglishMaxGrade2.Text = $"";
            Lab_EnglishMinGrade2.Text = $"";
            Lab_ScoreName.Text = "";
            Lab_ScoreChiese.Text = "";
            Lab_ScoreEnglish.Text = "";
            Lab_ScoreMath.Text = "";
            Lab_ScoreName.Text = "";
            Lab_TotalGrade.Text = "";
            Lab_ChineseMaxGrade2.Text = "";
            Lab_ChineseAgvgrade2.Text = "";
            Lab_MathTotalGrade2.Text = "";
            Lab_EnglishTotalGrade2.Text = "";
            Lab_MathAgvGrade2.Text = "";
            Lab_EnglishAgvGrade2.Text = "";
            Lab_MaxGrade.Text = "";
            Lab_MinGrade.Text = "";
            Lab_AgvGrade.Text = "";
            Lab_ChineseTotalGrade2.Text = "";
            chineseGrade = 0;
            mathGrade = 0;
            englishGrade = 0;
            totalChineseGrade = 0;
            totalEnglishGrade = 0;
            totalMathGrade = 0;
            Btn_statistics.Enabled = false;

        }
    }
}
