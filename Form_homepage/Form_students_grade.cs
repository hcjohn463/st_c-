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
    public partial class Form_students_grade : Form
    {
        public Form_students_grade()
        {
            InitializeComponent();
        }
        private void add_one_line(string name, double chinese_grade, double english_grade, double math_grade)
        {
            double total = chinese_grade + english_grade + math_grade;
            double average = Math.Round(total / 3, 1);
            string one_line = String.Format("{0,-7}", name) + String.Format("{0,-7}", chinese_grade)
                + String.Format("{0,-8}", english_grade) + String.Format("{0,-7}", math_grade)
                + String.Format("{0,-7}", total) + String.Format("{0,-8}", average)
                + get_min_max(chinese_grade, english_grade, math_grade) + "\r\n";
            this.textbox_students_grade_statics.Text += one_line;
            //可以統計了
            this.button_students_grade_total.Enabled = true;

        }
        private void button_students_grade_insert_Click(object sender, EventArgs e)
        {
            string name = textbox_students_grade_name.Text;
            names.Add(name);
            double chinese_grade = (double.Parse(textbox_students_grade_chinese.Text));
            chinese_grades.Add(chinese_grade);
            double english_grade = (double.Parse(textbox_students_grade_english.Text));
            english_grades.Add(english_grade);
            double math_grade = (double.Parse(textbox_students_grade_math.Text));
            math_grades.Add(math_grade);
            add_one_line(name, chinese_grade, english_grade, math_grade);
        }
        
        string get_min_max(double chinese_grade, double english_grade, double math_grade)
        {
            List<double> three_grades = new List<double>();
            three_grades.Add(chinese_grade);
            three_grades.Add(english_grade);
            three_grades.Add(math_grade);

            int max_index = three_grades.IndexOf(three_grades.Max());
            int min_index = three_grades.IndexOf(three_grades.Min());
            string result = "";

            List<string> three_names = new List<string>() {"國文","英文","數學"};
            result += String.Format("{0,-7}", three_names[min_index] + three_grades[min_index]);
            result += three_names[max_index] + three_grades[max_index];
            return result;
        }

        private void button_students_grade_total_Click(object sender, EventArgs e)
        {
            double chinese_sum = this.chinese_grades.Sum();
            double english_sum = this.english_grades.Sum();
            double math_sum = this.math_grades.Sum();
            double chinese_average = Math.Round(chinese_sum / this.chinese_grades.Count(), 1);
            double english_average = Math.Round(english_sum / this.english_grades.Count(), 1);
            double math_average = Math.Round(math_sum / this.math_grades.Count(), 1);
            double max_chinese_grade = this.chinese_grades.Max();
            double max_english_grade = this.english_grades.Max();
            double max_math_grade = this.math_grades.Max();
            double min_chinese_grade = this.chinese_grades.Min();
            double min_english_grade = this.english_grades.Min();
            double min_math_grade = this.math_grades.Min();

            string text = String.Format("{0,-7}", "總分") + String.Format("{0,-7}", chinese_sum)
                + String.Format("{0,-8}", english_sum) + String.Format("{0,-7}", math_sum) + "\r\n"
                + String.Format("{0,-7}", "平均") + String.Format("{0,-7}", chinese_average)
                + String.Format("{0,-8}", english_average) + String.Format("{0,-7}", math_average) + "\r\n"
                + String.Format("{0,-7}", "最高分") + String.Format("{0,-7}", max_chinese_grade)
                + String.Format("{0,-8}", max_english_grade) + String.Format("{0,-7}", max_math_grade) + "\r\n"
                + String.Format("{0,-7}", "最低分") + String.Format("{0,-7}", min_chinese_grade)
                + String.Format("{0,-8}", min_english_grade) + String.Format("{0,-7}", min_math_grade) + "\r\n";

            this.textbox_students_grade_final.Text = text;

            //其他不能按
            enable_option(false);
        }

        private void button_students_grade_reset_Click(object sender, EventArgs e)
        {
            enable_option(true);
            this.button_students_grade_total.Enabled = false;
            this.textbox_students_grade_name.Text = "0";
            this.textbox_students_grade_chinese.Text = "0";
            this.textbox_students_grade_english.Text = "0";
            this.textbox_students_grade_math.Text = "0";
            this.textbox_students_grade_statics.Text = "姓名   國文   英文   數學    總分    平均    最低    最高    \r\n";
            this.textbox_students_grade_final.Text = "";
            name = "";
            chinese = english = math = 0;
            random_number = 0;
            names.Clear();
            chinese_grades.Clear();
            english_grades.Clear();
            math_grades.Clear();
    }
        private void enable_option(Boolean flag)
        {
            //其他不能按
            this.button_students_grade_insert.Enabled = flag;
            this.button_students_grade_random_insert.Enabled = flag;
            this.button_students_grade_total.Enabled = flag;
            this.button_students_grade_random_insert20.Enabled = flag;
        }

        private void button_students_grade_random_insert_Click(object sender, EventArgs e)
        {
            produce_random_number();
        }

        private void produce_random_number()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            random_number += 1;
            string name = random_number.ToString();
            names.Add(name);
            int chinese_grade = random.Next(101);
            int english_grade = random.Next(101);
            int math_grade = random.Next(101);
            chinese_grades.Add(chinese_grade);
            english_grades.Add(english_grade);
            math_grades.Add(math_grade);
            add_one_line(name, chinese_grade, english_grade, math_grade);
        }

        private void button_students_grade_random_insert20_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                produce_random_number();
            }
        }
    }
}
