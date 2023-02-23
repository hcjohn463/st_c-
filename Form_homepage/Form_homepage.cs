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
    public partial class Form_homepage : Form
    {
        public Form_homepage()
        {
            InitializeComponent();
        }

        private void button_hello_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_hello my_form_hello = new Form_hello()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_hello.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_hello);
            my_form_hello.Show();
        }

        private void button_loan_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_loan my_form_loan = new Form_loan()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_loan.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_loan);
            my_form_loan.Show();
        }

        private void button_student_struct_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_student_struct my_form_student_struct = new Form_student_struct()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_student_struct.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_student_struct);
            my_form_student_struct.Show();
        }

        private void button_students_grade_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_students_grade my_form_students_grade = new Form_students_grade()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_students_grade.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_students_grade);
            my_form_students_grade.Show();
        }

        private void button_students_grade_list_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_students_grade_list my_form_students_grade_list = new Form_students_grade_list()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_students_grade_list.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_students_grade_list);
            my_form_students_grade_list.Show();
        }

        private void button_pos_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_pos my_form_pos = new Form_pos()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_form_pos.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_form_pos);
            my_form_pos.Show();
        }

        private void button_my_clac_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_my_clac my_my_clac = new Form_my_clac()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_my_clac.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_my_clac);
            my_my_clac.Show();
        }

        private void button_xo_game_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_xo_game my_xo_game = new Form_xo_game()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_xo_game.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_xo_game);
            my_xo_game.Show();
        }

        private void button_guess_number_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_guess_number my_guess_number = new Form_guess_number()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_guess_number.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_guess_number);
            my_guess_number.Show();
        }

        private void button_alarm_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_alarm my_alarm = new Form_alarm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_alarm.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_alarm);
            my_alarm.Show();
        }

        private void button_method_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_method my_method = new Form_method()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_method.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_method);
            my_method.Show();
        }

        private void button_for_do_while_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_for_do_while my_for_do_while = new Form_for_do_while()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_for_do_while.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_for_do_while);
            my_for_do_while.Show();
        }

        private void button_drawpaint_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_drawpaint my_drawpaint = new Form_drawpaint()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_drawpaint.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_drawpaint);
            my_drawpaint.Show();
        }

        private void button_picture_viewer_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_picture_viewer my_picture_viewer = new Form_picture_viewer()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            my_picture_viewer.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.panel_container.Controls.Add(my_picture_viewer);
            my_picture_viewer.Show();
        }

        private void button_screen_saver_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_screen_saver my_screen_saver = new Form_screen_saver();
            my_screen_saver.Show();
        }

        private void button_notepad_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            Form_notepad my_notepad = new Form_notepad();
            my_notepad.Show();
        }
    }
}
