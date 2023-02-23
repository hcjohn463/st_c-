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
    public partial class Form_loan : Form
    {
        public Form_loan()
        {
            InitializeComponent();
        }

        private void button_loan_pmt_Click(object sender, EventArgs e)
        {
            int monthly_principal = get_pmt();
            MessageBox.Show("月付額: " + monthly_principal);
        }
        public int get_pmt()
        {
            int[] ans = calculate_loan();
            return ans[1]; // 每月償還本金
        }
        public int[] calculate_loan()
        {
            //貸款金額
            int loan_money = int.Parse(textbox_loan_amount.Text) - int.Parse(textbox_loan_downpayment.Text);
            double loan_year_rate = 0.01 * double.Parse(textbox_loan_rate.Text); //年利率(%)
            int loan_year = int.Parse(textbox_loan_year.Text); //貸款期數(年)
            int monthly_principal = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(loan_money) / Convert.ToDouble(loan_year * 12))); // 每月償還本金
            double loan_month_rate = loan_year_rate / 12; //月利率
            int remain_loan_money = loan_money; // 貸款餘額
            int total_interest = 0; //總利息
            while (remain_loan_money > 0)
            {
                //每月償還利息
                int monthly_interest = Convert.ToInt32((remain_loan_money * loan_month_rate));
                total_interest += monthly_interest;
                int monthly_needpay = monthly_principal + monthly_interest;
                remain_loan_money -= monthly_principal;
            }
            int[] ans = new int[] {total_interest, monthly_principal};
            return ans;
        }

        private void button_loan_total_Click(object sender, EventArgs e)
        {
            int loan_total = get_loan_total();
            MessageBox.Show("總付款: " + loan_total);
        }
        public int get_loan_total()
        {
            int[] ans = calculate_loan();
            return ans[0]; // 每月償還本金
        }

        private void button_loan_report_Click(object sender, EventArgs e)
        {
            int[] ans = calculate_loan();
            int pmt = ans[1];
            int loan_total = ans[0];
            int loan_money = int.Parse(textbox_loan_amount.Text) - int.Parse(textbox_loan_downpayment.Text);
            string str_loan_money = Convert.ToString(loan_money);
            Form_loan_report loan_report  = new Form_loan_report(str_loan_money, textbox_loan_year.Text, textbox_loan_rate.Text, ans[1], loan_money + ans[0]);
            loan_report.Show();
        }
    }
}
