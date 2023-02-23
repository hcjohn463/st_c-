using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Form_homepage
{
    public partial class Form_method : Form
    {
        public Form_method()
        {
            InitializeComponent();
        }
        List<int> number_list = new List<int>() { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        List<string> string_list = new List<string>() { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker"};
        int n1 = 100;
        int n2 = 200;

        private void button_method_check_oddeven_Click(object sender, EventArgs e)
        {
            if (this.textbox_method_number.Text == "")
            {
                show_error();
            }
            else if (is_number(this.textbox_method_number.Text))
            {
                int num = Convert.ToInt32(this.textbox_method_number.Text);
                string text = "輸入的數 " + num + "為 ";
                if(num % 2 == 0)
                {
                    text += "偶數";
                }
                else
                {
                    text += "奇數";
                }
                this.label_method_result.Text = text;
            }
            else
            {
                show_error();
            }
        }
        private void show_error()
        {
            MessageBox.Show("請輸入數值");
        }

        public bool is_number(string value)
        {
            return value.All(char.IsNumber);
        }

        private void button_method_clear_Click(object sender, EventArgs e)
        {
            this.label_method_result.Text = "結果";
        }

        private void button_method_array_maxmin_Click(object sender, EventArgs e)
        {
            string text = get_elements() + "最大值為 " + number_list.Max()
                + "\r\n最小值為 " + number_list.Min();
            this.label_method_result.Text = text;
        }
        private string get_elements()
        {
            string array_elements = "";
            for (int i = 0; i < number_list.Count(); i++)
            {
                if (i != 0)
                {
                    array_elements += ", ";
                }
                array_elements += number_list[i].ToString();
            }
            return "int陣列Array [" + array_elements + "]\r\n";
        }

        private void button_method_oddeven_number_Click(object sender, EventArgs e)
        {
            int even_number = 0;
            foreach(int i in number_list)
            {
                if(i % 2 == 0)
                {
                    even_number++;
                }
            }
            string text = get_elements() + "奇數共 " + (number_list.Count() - even_number)
                + "\r\n偶數共 " + even_number;
            this.label_method_result.Text = text;
        }

        private void button_method_sum_array_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int i in number_list)
            {
                sum += i;
            }
            string text = get_elements() + "加總為 " + sum;
            this.label_method_result.Text = text;
        }

        private void button_method_max_array_Click(object sender, EventArgs e)
        {
            string text = get_elements() + "最大值為 " + number_list.Max();
            this.label_method_result.Text = text;
        }

        private void button_method_min_array_Click(object sender, EventArgs e)
        {
            string text = get_elements() + "最小值為 " + number_list.Min();
            this.label_method_result.Text = text;
        }

        private void button_method_swap_int_Click(object sender, EventArgs e)
        {
            string text = "換位前n1=" + n1 + " , n2=" + n2 + "\r\n";
            n1 = n1 ^ n2;
            n2 = n1 ^ n2;
            n1 = n1 ^ n2;
            text += "換位後n1=" + n1 + " , n2=" + n2;
            this.label_method_result.Text = text;
        }

        private void button_method_array10_edge1_Click(object sender, EventArgs e)
        {
            List<int> up_dowm_row = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            List<int> middle_row = new List<int>() { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            List<List<int>> my_2darray = new List<List<int>>();
            my_2darray.Add(up_dowm_row);
            for(int i = 0; i < 8 ; i++)
            {
                my_2darray.Add(middle_row);
            }
            my_2darray.Add(up_dowm_row);
            show_2darray(my_2darray);
        }
        private void show_2darray(List<List<int>> my_2darray)
        {
            string text = "";
            for (int i = 0; i < my_2darray.Count(); i++)
            {
                string tmp = "";
                for (int j = 0; j < my_2darray[0].Count(); j++)
                {
                    if (j != 0)
                    {
                        tmp += "  ";
                    }
                    tmp += my_2darray[i][j].ToString();
                }
                text += tmp;
                text += "\r\n";
            }
            this.label_method_result.Text = text;
        }

        private void button_method_array10_edge0_Click(object sender, EventArgs e)
        {
            List<int> up_dowm_row = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            List<int> middle_row = new List<int>() { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 };
            List<List<int>> my_2darray = new List<List<int>>();
            my_2darray.Add(up_dowm_row);
            for (int i = 0; i < 8; i++)
            {
                my_2darray.Add(middle_row);
            }
            my_2darray.Add(up_dowm_row);
            show_2darray(my_2darray);
        }

        private void button_method_array10_intersect_Click(object sender, EventArgs e)
        {
            List<int> first1 = new List<int>() { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            List<int> first0 = new List<int>() { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
            List<List<int>> my_2darray = new List<List<int>>();
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    my_2darray.Add(first1);
                }
                else
                {
                    my_2darray.Add(first0);
                }
            }
            show_2darray(my_2darray);
        }

        private void button_string_array_c_count_Click(object sender, EventArgs e)
        {
            int count_c;
            string text = "string陣列Array [" + show_string_elements(out count_c) + "]\r\n"
                + "\r\n有C 及 c的名字共有 " + count_c + " 個";
            this.label_method_result.Text = text;
        }
        private string show_string_elements(out int count_c)
        {
            count_c = 0;
            string array_elements = "";
            for (int i = 0; i < string_list.Count(); i++)
            {
                if (i != 0)
                {
                    array_elements += ", ";
                    if (i % 4 == 0)
                    {
                        array_elements += "\r\n";
                    }
                }
                array_elements += string_list[i].ToString();
                if (string_list[i].Contains('c') || string_list[i].Contains('C'))
                {
                    count_c++;
                }
            }
            return array_elements;
        }

        private void button_method_string_array_mostlen_Click(object sender, EventArgs e)
        {
            int count_c;
            string text = "string陣列Array [" + show_string_elements(out count_c) + "]\r\n"
                + "\r\n最長的名字為" + string_list.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur); ;
            this.label_method_result.Text = text;
        }
    }
}
