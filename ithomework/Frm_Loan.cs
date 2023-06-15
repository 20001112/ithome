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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();

        }




        private void Btn_PMT_Click(object sender, EventArgs e)
        {
            decimal loanAmount;
            if (!decimal.TryParse(txt_Loan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額");
                return;
            }

            int loanTerm;
            if (!int.TryParse(txt_Year.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限");
                return;
            }

            decimal interestRate;
            if (!decimal.TryParse(txt_interest.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的利率");
                return;
            }

            decimal downPayment;
            if (!decimal.TryParse(txt_Head.Text, out downPayment))
            {
                downPayment = 0;
            }

            int totalMonths = loanTerm * 12;
            decimal monthlyInterestRate = interestRate / 100 / 12;
            decimal loanBalance = loanAmount - downPayment;

            decimal monthlyPayment = loanBalance * monthlyInterestRate /
                                     (decimal)(1 - Math.Pow((double)(1 + monthlyInterestRate), -totalMonths));
            int roundedMonthlyPayment = (int)Math.Round(monthlyPayment);

            string message = "每月付款金額：" + roundedMonthlyPayment.ToString("c");
            string title = "貸款計算結果";

            MessageBox.Show(message, title);





        }
        
        

        
        private void Btn_Total_Click(object sender, EventArgs e)
        {
            decimal loanAmount;
            if (!decimal.TryParse(txt_Loan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額");
                return;
            }

            int loanTerm;
            if (!int.TryParse(txt_Year.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限");
                return;
            }

            decimal interestRate;
            if (!decimal.TryParse(txt_interest.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的利率");
                return;
            }

            decimal downPayment;
            if (!decimal.TryParse(txt_Head.Text, out downPayment))
            {
                downPayment = 0;
            }
            int totalMonths = loanTerm * 12;
            decimal monthlyInterestRate = interestRate / 100 / 12;
            decimal loanBalance = loanAmount - downPayment;
            decimal monthlyPayment = loanBalance * monthlyInterestRate /
                                     (decimal)(1 - Math.Pow((double)(1 + monthlyInterestRate), -totalMonths));
            int roundedMonthlyPayment = (int)Math.Round(monthlyPayment);
            int totalPayment = (int)(roundedMonthlyPayment * totalMonths);
            string message = "總金額:" + totalPayment;
            MessageBox.Show(message);

        }

        public void Btn_Report_Click(object sender, EventArgs e)
        {
            decimal loanAmount;
            if (!decimal.TryParse(txt_Loan.Text, out loanAmount))
            {
                MessageBox.Show("請輸入有效的貸款金額");
                return;
            }

            int loanTerm;
            if (!int.TryParse(txt_Year.Text, out loanTerm))
            {
                MessageBox.Show("請輸入有效的貸款期限");
                return;
            }

            decimal interestRate;
            if (!decimal.TryParse(txt_interest.Text, out interestRate))
            {
                MessageBox.Show("請輸入有效的利率");
                return;
            }

            decimal downPayment;
            if (!decimal.TryParse(txt_Head.Text, out downPayment))
            {
                downPayment = 0;
            } // 检查是否填入了值，若未填入则设为 0
            int totalMonths = loanTerm * 12;
            decimal monthlyInterestRate = interestRate / 100 / 12;
            decimal loanBalance = loanAmount - downPayment;
            decimal monthlyPayment = loanBalance * monthlyInterestRate /
                                     (decimal)(1 - Math.Pow((double)(1 + monthlyInterestRate), -totalMonths));
            int roundedMonthlyPayment = (int)Math.Round(monthlyPayment);

            string message = "每月付款金額：" + roundedMonthlyPayment.ToString("c");
            int totalPayment = (int)(roundedMonthlyPayment * totalMonths);
            string totalmessage = "總金額:" + totalPayment;
            string interestRateString = interestRate.ToString();
            string loanTermmessage = loanTerm.ToString();


            Frm_Report reportForm = new Frm_Report(loanAmount, loanTerm, roundedMonthlyPayment, interestRate, totalPayment);
            reportForm.Show();
        }

        private void Frm_Loan_Load(object sender, EventArgs e)
        {

        }
    }


}
