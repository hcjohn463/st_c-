using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_homepage
{
    public partial class Form_loan_report : Form
    {
        public Form_loan_report(string loan_money, string long_year, string loan_rate, int pmt, int total)
        {
            InitializeComponent();
            this.label_loan_report_amount_value.Text = loan_money;
            this.label_loan_report_year_value.Text = long_year;
            this.label_loan_report_rate_value.Text = loan_rate;
            this.label_monthly_payment_value.Text = Convert.ToString(pmt);
            this.label_total_payment_value.Text = Convert.ToString(total);
        }
    }
}
