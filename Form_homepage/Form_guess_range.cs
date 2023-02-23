using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace Form_homepage
{
    public partial class Form_guess_range : Form
    {
        public Form_guess_range(Label origin_title)
        {
            InitializeComponent();
            label1 = origin_title;
        }
        Label label1;
        private void button_guess_range_enter_Click(object sender, EventArgs e)
        {
            if (this.textbox_guess_range_number.Text == "")
            {
                show_error();
            }
            else
            {
                int guess_number = int.Parse(this.textbox_guess_range_number.Text);
                if(guess_number == Form_guess_number.answer)
                {
                    //correct
                    MessageBox.Show("Congradulations!!! You got" + guess_number + "!!!");
                }
                else if(guess_number > Form_guess_number.down && guess_number < Form_guess_number.up)
                {
                    if(guess_number < Form_guess_number.answer)
                    {
                        Form_guess_number.down = guess_number;
                        label1.Text = "     Too Small!!!\r\n     Between "
                        + Form_guess_number.down + " and " + Form_guess_number.up + "";
                    }
                    else
                    {
                        Form_guess_number.up = guess_number;
                        label1.Text = "     Too Large!!!\r\n     Between "
                        + Form_guess_number.down + " and " + Form_guess_number.up + "";
                    }
                }
                else
                {
                    show_error();
                }
            }
        }
        private void show_error()
        {
            string text = "請輸入" + Form_guess_number.down + "~" + Form_guess_number.up + "之間的數字";
            MessageBox.Show(text, "錯誤", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button_guess_range_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
