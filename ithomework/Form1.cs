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
    public partial class Form1 : Form
    {
        private Form currentForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            ShowForm<Frm_Hello>();

        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            ShowForm<Frm_Loan>();

        }

        private void BtnPos_Click(object sender, EventArgs e)
        {
            ShowForm<Frm_Pos>();

        }


        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Control[] controls = splitContainer1.Panel1.Controls.Cast<Control>().ToArray();
            foreach (Control control in controls)
            {
                control.Size = new Size(control.Size.Width, splitContainer1.Panel1.Height);
            }
        }

        private void BtnStudentStrucForm_Click(object sender, EventArgs e)
        {
            ShowForm<Frm_Student_StrucForm>();

        }

        private void BtnStudentGrade_Click(object sender, EventArgs e)
        {
            ShowForm<Frm_StudentsGrade>();

        }

        private void Btn_MyClac_Click(object sender, EventArgs e)
        {
            ShowForm<MyClac>();


        }

        private void Btn_Guess_Click(object sender, EventArgs e)
        {
            ShowForm<考試_Guess>();

        }
        private void ShowForm<T>() where T : Form, new()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            T frm = new T();
            currentForm = frm;
            frm.Show();
        }

        private void Btn_小畫家_Click(object sender, EventArgs e)
        {
            ShowForm<小畫家>();

        }

        private void Btn_Alarm_Click(object sender, EventArgs e)
        {

            ShowForm<Alarm>();
        }
    }
}
