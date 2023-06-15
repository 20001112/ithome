using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ithomework
{
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            string message = "Hello, 我是" + name + "\n" +
                             "英文名字是" + EnglishName + "\n" +
                             "性別是" + Gender + "\n" +
                             "星座是" + Constellation + "\n" +
                             "很高興認識你";
            System.Windows.Forms.MessageBox.Show(message);



        }

        private void BtnSayHI_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            string message = "Hello, 我是" + name + "\n" +
                             "英文名字是" + EnglishName + "\n" +
                             "性別是" + Gender + "\n" +
                             "星座是" + Constellation + "\n" +
                             "很高興認識你";
            System.Windows.Forms.MessageBox.Show(message);

        }
    }
}
