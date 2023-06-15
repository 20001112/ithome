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
    public partial class Frm_Student_StrucForm : Form
    {
        public Frm_Student_StrucForm()
        {
            InitializeComponent();
        }
        string TotalGrade;
        string MaxGrade;
        string MinGrade;
        public void Btn_Save_Click(object sender, EventArgs e)
        {   
            Employee emp=new Employee();
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("請輸入姓名");
                return;
            }
            else
            {
                emp.Name = txt_Name.Text;

            }
            int chineseScore;
            if (int.TryParse(txt_Chinese.Text, out chineseScore))
            {
                emp.Chinese = chineseScore;
            }
            else
            {
                MessageBox.Show("請輸入正確的國文成績");
            }
            int MathScore;
            if(int.TryParse(txt_Math.Text,out MathScore))
            {
                emp.Math = MathScore;
            }
            int EnglishScore;
            if(int.TryParse(txt_English.Text,out EnglishScore))
            {
                emp.English = EnglishScore;
            }
            TotalGrade = "姓名" + emp.Name + "\n" +
            "國文成績" + emp.Chinese + "\n" +
            "數學成績" + emp.Math + "\n" +
           "英文成績" + emp.English ;
            int max = Math.Max(Math.Max(emp.Math, emp.Chinese), emp.English);
            int min = Math.Min(Math.Min(emp.Math, emp.Chinese), emp.English);
            if (max ==emp.Math)
            {
                MaxGrade = "最高成績的科目為數學" + emp.Math;
            }
            else if(max==emp.Chinese)
            {
                MaxGrade = "最高成績的科目為國文" + emp.Chinese;
            }
            else if (min ==emp.English)
            {
                MaxGrade = "最高成績的科目為英文" + emp.English;
            }
            if(min ==emp.Math)
            {
                MinGrade = "最高成績的科目為數學" + emp.Math;
            }
            else if (min == emp.Chinese)
            {
                MinGrade = "最高成績的科目為國文" + emp.Chinese;
            }
            else if (min == emp.English)
            {
                MinGrade = "最高成績的科目為英文" + emp.English;
            }


        }

        private void Frm_Student_StrucForm_Load(object sender, EventArgs e)
        {


        }

        private void Btn_LookSave_Click(object sender, EventArgs e)
        {

            Lab_grade.Text = TotalGrade;
        }

        private void Btn_List_Click(object sender, EventArgs e)
        {
            Lab_High.Text = MaxGrade + "\n" + MinGrade;
        }
    }
}
