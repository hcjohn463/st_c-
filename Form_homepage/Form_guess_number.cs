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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_homepage
{
    public partial class Form_guess_number : Form
    {
        public Form_guess_number()
        {
            InitializeComponent();
            create_number();
        }
        public static int answer = 0;
        public static int up = 100;
        public static int down = 1;
        public static int guess_number = 0;

        private void create_number()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            answer = random.Next(1, 101);
        }
        private void button_guess_number_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: " + answer);
            create_number();
        }

        private void button_geuss_number_guess_Click(object sender, EventArgs e)
        {
            Form_guess_range my_guess_range = new Form_guess_range(this.label_guess_number_title);
            my_guess_range.ShowDialog();
        }
    }
}
