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
    public partial class Form_for_do_while : Form
    {
        public Form_for_do_while()
        {
            InitializeComponent();
        }

        private void button_100binary_Click(object sender, EventArgs e)
        {
            string binary = Convert.ToString(100, 2);
            this.label_result.Text = binary;
        }

        private void button_tree_Click(object sender, EventArgs e)
        {
            if (this.textbox_rows.Text == "")
            {
                show_error();
            }
            else if (is_number(this.textbox_rows.Text))
            {
                string text = "";
                int row = int.Parse(this.textbox_rows.Text);
                for(int i = 0 ; i < row ; i++)
                {
                    string tmp = "";
                    for(int j = 0; j <= i; j++)
                    {
                        tmp += "*";
                    }
                    text += tmp;
                    text += "\r\n";
                }
                this.label_result.Text = text;
            }
            else
            {
                show_error();
            }
        }
        public bool is_number(string value)
        {
            return value.All(char.IsNumber);
        }
        private void show_error()
        {
            MessageBox.Show("請輸入數值");
        }

        private void button_99_Click(object sender, EventArgs e)
        {
            string text = "九九乘法表\r\n";
            for(int i = 1; i < 10; i++)
            {
                string tmp = "";
                for(int j = 2; j < 10; j++)
                {
                    //if+後靠 -前靠
                    tmp += (String.Format("{0,3}x {1,2}={2,2} {3,-2}", j,i,j*i,"|"));
                }
                text += tmp;
                text += "\r\n";
            }
            this.label_result.Text = text;
        }

        private void button_lotto_Click(object sender, EventArgs e)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            HashSet<int> lottos = new HashSet<int>();
            while (true)
            {
                if(lottos.Count() == 6)
                {
                    break;
                }
                lottos.Add(random.Next(1,50));
            }
            string text = "樂透號碼\r\n";
            foreach(int i in lottos)
            {
                text += "  ";
                text += i.ToString();
            }
            this.label_result.Text = text;
        }
        private void check_numbers()
        {
            if (is_number(this.textbox_from.Text) && is_number(this.textbox_to.Text) && is_number(this.textbox_step.Text))
            {
                //correct
            }
            else
            {
                show_error();
            }
        }
        delegate int Get_count(int from, int to, int step);

        private int get_for_count(int from,int to,int step)
        {
            int sum = 0;
            for (int i = from; i <= to; i += step)
            {
                sum += i;
            }
            return sum;
        }
        private int get_while_count(int from, int to, int step)
        {
            int sum = 0;
            while(from <= to)
            {
                sum += from;
                from += step;
            }
            return sum;
        }
       private int get_do_count(int from, int to, int step)
        {
            int sum = 0;
            do
            {
                sum += from;
                from += step;
            } while (from <= to);
            return sum;
        }
        private void select_countway(int flag)
        {
            //flag = 0 for
            //flag = 1 while
            //flage = 2 do
            check_numbers();
            int from = int.Parse(this.textbox_from.Text);
            int to = int.Parse(this.textbox_to.Text);
            int step = int.Parse(this.textbox_step.Text);
            int sum = 0;
            if (step <= 0)
            {
                show_error();
            }
            else
            {
                //delegate
                Get_count get_count;
                if(flag == 0)
                {
                    get_count = get_for_count;
                    sum = get_count(from, to, step);
                }
                else if(flag == 1)
                {
                    get_count = get_while_count;
                    sum = get_count(from, to, step);
                }
                else
                {
                    get_count = get_do_count;
                    sum = get_count(from, to, step);
                }
                string text = from + "   到   " + to + "  相隔  " + step + "\r\n";
                text += ("加總為 " + sum);
                this.label_result.Text = text;
            }
        }
        private void button_for_Click(object sender, EventArgs e)
        {
            select_countway(0); //for
        }

        private void button_while_Click(object sender, EventArgs e)
        {
            select_countway(1); //while
        }

        private void button_do_Click(object sender, EventArgs e)
        {
            select_countway(2); //do
        }
    }
}
