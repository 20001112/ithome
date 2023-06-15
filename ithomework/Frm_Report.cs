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
    public partial class Frm_Report : Form
    {


        public Frm_Report(decimal loanAmount, int loanTerm, int roundedMonthlyPayment, decimal interestRate, int totalmessage)
        {
            Frm_Loan frm = new Frm_Loan();
            InitializeComponent();


            Lab_LoanAmount.Text = loanAmount.ToString();
            Lab_loanTerm.Text = loanTerm.ToString();
            Lab_message.Text = interestRate.ToString();
            Lab_month.Text = roundedMonthlyPayment.ToString();
            Lab_Total.Text = totalmessage.ToString();


        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {

        }

        private void Lab_LoanAmount_Click(object sender, EventArgs e)
        {

        }
    }

}
