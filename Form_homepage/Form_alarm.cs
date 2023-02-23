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
    public partial class Form_alarm : Form
    {
        public Form_alarm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
            alarm_on = false;
        }
        Timer timer;
        Boolean alarm_on;

        private void timer_tick(object sender, EventArgs e)
        { 
            this.label_alarm_nowtime.Text = DateTime.Now.ToString("HH:mm:ss ");
            if (alarm_on)
            {
                string hour = this.textbox_hour.Text;
                string minute = this.textbox_alarm_minute.Text;
                string second = this.textbox_alarm_second.Text;
                if (DateTime.Now.ToString("HH") == hour &&
                    DateTime.Now.ToString("mm") == minute &&
                    DateTime.Now.ToString("ss") == second)
                {
                    alarm_on = false;
                    MessageBox.Show("Wake up !");
                }
            }
        }

        private void checkbox_alarm_CheckedChanged(object sender, EventArgs e)
        {
            alarm_on = true;
        }
    }
}
