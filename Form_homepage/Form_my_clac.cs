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
    public partial class Form_my_clac : Form
    {
        public Form_my_clac()
        {
            InitializeComponent();
        }

        private void button_my_clas_plus_Click(object sender, EventArgs e)
        {
            if (num_exist())
            {
                show_answer('+');
            }
            else { }
        }
        private void show_answer(char operate)
        {
            double num1 = double.Parse(this.textbox_my_clac_num1.Text);
            double num2 = double.Parse(this.textbox_my_clac_num2.Text);
            double result = 0;
            switch (operate)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default://以上都不符合走這個
                    result = Math.Round(num1 / num2, 4);
                    break;
            }
            this.textbox_my_clac_answer.Text = result.ToString();
        }

        private Boolean num_exist()
        {
            if(this.textbox_my_clac_num1.Text == "" || this.textbox_my_clac_num2.Text == "")
            {
                MessageBox.Show("請輸入數值");
                return false;
            }
            return true;
        }

        private void button_my_clac_minus_Click(object sender, EventArgs e)
        {
            if (num_exist())
            {
                show_answer('-');
            }
            else { }
        }

        private void button_my_clac_times_Click(object sender, EventArgs e)
        {
            if (num_exist())
            {
                show_answer('*');
            }
            else { }
        }

        private void button_my_clac_divide_Click(object sender, EventArgs e)
        {
            if (num_exist())
            {
                show_answer('/');
            }
            else { }
        }
    }
}
