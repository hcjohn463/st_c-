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
    public partial class Form_hello : Form
    {
        public Form_hello()
        {
            InitializeComponent();
        }
        string get_message(string sayword)
        {
            string hello_name = textbox_hello_name.Text;
            string hello_english_name = textbox_hello_english_name.Text;
            string hello_sexual = textbox_hello_sexual.Text;
            string hello_starsign = textbox_hello_starsign.Text;
            string message = sayword + ", 我是," + hello_name + "\n"
                + "英文名字是," + hello_english_name + "\n"
                + "性別是," + hello_sexual + "\n"
                + "星座是," + hello_starsign + "\n"
                + "很高興認識你。";
            return message;
        }

        private void button_hello_sayhello_Click(object sender, EventArgs e)
        {
            MessageBox.Show(get_message("hello"));
        }

        private void button_hello_sayhi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(get_message("hi"));
        }
    }
}
