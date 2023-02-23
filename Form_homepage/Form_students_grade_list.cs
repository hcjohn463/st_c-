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
    public partial class Form_students_grade_list : Form
    {
        public Form_students_grade_list()
        {
            InitializeComponent();
        }
        private string one_line(string name, double chinese_grade, double english_grade, double math_grade)
        {
            double total = chinese_grade + english_grade + math_grade;
            double average = Math.Round(total / 3, 1);
            string line = String.Format("{0,-7}", name) + String.Format("{0,-7}", chinese_grade)
                + String.Format("{0,-8}", english_grade) + String.Format("{0,-7}", math_grade)
                + String.Format("{0,-7}", total) + String.Format("{0,-8}", average)
                + get_min_max(chinese_grade, english_grade, math_grade) + "\r\n";
            return line;
        }
        private void add_down_line(string text)
        {
            statics.Add(text);
        }
        private void add_up_line(string text)
        {
            statics.Insert(1, text);
        }
        private void button_students_grade_list_downinsert_Click(object sender, EventArgs e)
        {
            string name = textbox_students_grade_list_name.Text;
            names.Add(name);
            double chinese_grade = (double.Parse(textbox_students_grade_list_chinese.Text));
            chinese_grades.Add(chinese_grade);
            double english_grade = (double.Parse(textbox_students_grade_list_english.Text));
            english_grades.Add(english_grade);
            double math_grade = (double.Parse(textbox_students_grade_list_math.Text));
            math_grades.Add(math_grade);
            add_down_line(one_line(name, chinese_grade, english_grade, math_grade));
            show_statics();
            //可以統計了
            this.button_students_grade_list_total.Enabled = true;
            //可以移除了
            this.button_students_grade_list_remove.Enabled = true;

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

            List<string> three_names = new List<string>() { "國文", "英文", "數學" };
            result += String.Format("{0,-7}", three_names[min_index] + three_grades[min_index]);
            result += three_names[max_index] + three_grades[max_index];
            return result;
        }
        private void show_statics()
        {
            string result = "";
            for(int i = 0; i < statics.Count(); i++)
            {
                result += statics[i];
            }
            this.textbox_students_grade_statics.Text = result;
        }

        private void button_students_grade_clear_Click(object sender, EventArgs e)
        {
            this.button_students_grade_list_downinsert.Enabled = true;
            this.button_students_grade_list_upinsert.Enabled = true;

            this.textbox_students_grade_list_name.Text = "0";
            this.textbox_students_grade_list_chinese.Text = "0";
            this.textbox_students_grade_list_english.Text = "0";
            this.textbox_students_grade_list_math.Text = "0";
            this.textbox_students_grade_final.Text = "";
            this.button_students_grade_list_remove.Enabled = false;
            statics.Clear();
            statics.Add("姓名   國文   英文   數學    總分    平均    最低    最高    \r\n");
            show_statics();
            name = "";
            chinese = english = math = 0;
            names.Clear();
            chinese_grades.Clear();
            english_grades.Clear();
            math_grades.Clear();
        }

        private void button_students_grade_list_upinsert_Click(object sender, EventArgs e)
        {
            string name = textbox_students_grade_list_name.Text;
            names.Insert(0, name);
            double chinese_grade = (double.Parse(textbox_students_grade_list_chinese.Text));
            chinese_grades.Insert(0,chinese_grade);
            double english_grade = (double.Parse(textbox_students_grade_list_english.Text));
            english_grades.Insert(0,english_grade);
            double math_grade = (double.Parse(textbox_students_grade_list_math.Text));
            math_grades.Insert(0,math_grade);
            add_up_line(one_line(name, chinese_grade, english_grade, math_grade));
            show_statics();
            //可以統計了
            this.button_students_grade_list_total.Enabled = true;
            //可以移除了
            this.button_students_grade_list_remove.Enabled = true;
        }

        private void button_students_grade_list_remove_Click(object sender, EventArgs e)
        {
            statics.RemoveAt(1);
            chinese_grades.RemoveAt(0);
            english_grades.RemoveAt(0);
            math_grades.RemoveAt(0);

            show_statics();
            //沒資料了
            if(statics.Count == 1)
            {
                this.button_students_grade_list_remove.Enabled = false;
            }
        }
        private void enable_option(Boolean flag)
        {
            this.button_students_grade_list_downinsert.Enabled = flag;
            this.button_students_grade_list_upinsert.Enabled = flag;
            this.button_students_grade_list_remove.Enabled = flag;
        }
        private void button_students_grade_list_total_Click(object sender, EventArgs e)
        {
            //統計了不能再做點擊
            enable_option(false);

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

        }

        private void button_chinese_search_Click(object sender, EventArgs e)
        {
            double chinese_down = double.Parse(this.textbox_chinese_down.Text);
            double chinese_up = double.Parse(this.textbox_chinese_up.Text);
            List<string> selected = new List<string>();
            selected.Add(statics[0]);
            for (int i = 0; i < chinese_grades.Count(); i++)
            {
                if (chinese_grades[i] >= chinese_down && chinese_grades[i] <= chinese_up)
                {
                    selected.Add(statics[i + 1]);
                }
            }
            string result = "";
            for (int i = 0; i < selected.Count(); i++)
            {
                result += selected[i];
            }
            this.textbox_students_grade_statics.Text = "";
            this.textbox_students_grade_statics.Text = result;
        }
    }
}
