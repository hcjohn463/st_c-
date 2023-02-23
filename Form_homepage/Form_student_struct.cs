using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_homepage
{
    public partial class Form_student_struct : Form
    {
        public Form_student_struct()
        {
            InitializeComponent();
        }
        private void button_student_struct_save_Click(object sender, EventArgs e)
        {
            name = textbox_student_struct_name.Text;
            chinese = Double.Parse(textbox_student_struct_chinese.Text);
            math = Double.Parse(textbox_student_struct_math.Text);
            english = Double.Parse(textbox_student_struct_english.Text);
        }
        private void button_student_struct_show_Click(object sender, EventArgs e)
        {
            string result = label_student_struct_name.Text + name + "\r\n"
                + label_student_struct_chinese.Text + chinese + "分\r\n"
                + label_student_struct_english.Text + english + "分\r\n"
                + label_student_struct_math.Text + math + "分\r\n";
            textbox_student_struct_result.Text = result;
        }


        private void button_student_struct_maxmin_Click(object sender, EventArgs e)
        {
            IDictionary<string, double> grades = new Dictionary<string, double>();
            grades.Add(label_student_struct_chinese.Text,chinese);
            grades.Add(label_student_struct_english.Text, english);
            grades.Add(label_student_struct_math.Text, math);

            //get max_key
            var max_grade_name = grades.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            //get_max_value
            var max_grade_value = grades.Values.Max();

            var min_grade_name = grades.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            //get_max_value
            var min_grade_value = grades.Values.Min();

            string result = "最高科目成績為： " + max_grade_name.Substring(0, max_grade_name.Length - 1) + max_grade_value + "分\r\n"
                + "最低科目成績為： " + min_grade_name.Substring(0, min_grade_name.Length - 1) + min_grade_value + "分";

            textbox_student_struct_compare.Text = result;
        }
    }
}
