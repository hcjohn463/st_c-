using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_homepage
{
    public partial class Form_notepad : Form
    {
        public Form_notepad()
        {
            InitializeComponent();
            this.textbox_notepad.Dock = DockStyle.Fill;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_display_time.Text = DateTime.Now.ToString("tt hh:mm:ss ");
        }
        string fileContent = string.Empty;
        string filePath = string.Empty;
        private void ToolStripMenuItem_open_Click(object sender, EventArgs e)
        {
            open_file();
        }
        private void open_file()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = get_pictures_path();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    this.textbox_notepad.Text = fileContent;
                }
            }
        }
        private string get_pictures_path()
        {
            string str = System.Windows.Forms.Application.StartupPath;
            string[] sArray = str.Split('\\');
            List<string> file_list = new List<string>();
            foreach (string s in sArray)
            {
                file_list.Add(s);
            }
            file_list.RemoveAt(file_list.Count() - 1);
            file_list.RemoveAt(file_list.Count() - 1);
            file_list.RemoveAt(file_list.Count() - 1);
            string ans = "";
            foreach (string s in file_list)
            {
                ans += s;
                ans += '\\';
            }
            return ans;
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_open_Click(object sender, EventArgs e)
        {
            open_file();
        }

        private void ToolStripMenuItem_font_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textbox_notepad.ForeColor = colorDialog1.Color;
            }
        }

        private void ToolStripMenuItem_font_type_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textbox_notepad.Font = fontDialog1.Font;
            }
        }

        private void ToolStripMenuItem_font_upper_Click(object sender, EventArgs e)
        {
            string res = this.textbox_notepad.Text.ToUpper();
            this.textbox_notepad.Text = res;
        }

        private void ToolStripMenuItem_font_lower_Click(object sender, EventArgs e)
        {
            string res = this.textbox_notepad.Text.ToLower();
            this.textbox_notepad.Text = res;
        }

        private void ToolStripMenuItem_color_red_Click(object sender, EventArgs e)
        {
            this.textbox_notepad.ForeColor = Color.Red;
        }

        private void ToolStripMenuItem_color_green_Click(object sender, EventArgs e)
        {
            this.textbox_notepad.ForeColor = Color.Green;
        }

        private void ToolStripMenuItem_color_blue_Click(object sender, EventArgs e)
        {
            this.textbox_notepad.ForeColor = Color.Blue;
        }

        private void ToolStripMenuItem_black_Click(object sender, EventArgs e)
        {
            this.textbox_notepad.ForeColor = Color.Black;
        }

        private void toolStripButton_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textbox_notepad.SelectedText);
        }

        private void toolStripButton_paste_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            textbox_notepad.Paste((String)iData.GetData(DataFormats.Text));
        }

        private void ToolStripMenuItem_allselect_Click(object sender, EventArgs e)
        {
            textbox_notepad.SelectAll();
        }

        private void ToolStripMenuItem_cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textbox_notepad.SelectedText);
            textbox_notepad.Cut();
        }

        private void toolStripButton_cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textbox_notepad.SelectedText);
            textbox_notepad.Cut();
        }

        private void ToolStripMenuItem_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textbox_notepad.SelectedText);
        }

        private void ToolStripMenuItem_paste_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            textbox_notepad.Paste((String)iData.GetData(DataFormats.Text));
        }

        private void toolStripButton_information_Click(object sender, EventArgs e)
        {
            Form_notepad_about my_notepad_about = new Form_notepad_about();
            my_notepad_about.ShowDialog();
        }

        private void ToolStripMenuItem_about_Click(object sender, EventArgs e)
        {
            Form_notepad_about my_notepad_about = new Form_notepad_about();
            my_notepad_about.ShowDialog();
        }

        private void ToolStripMenuItem_save_another_Click(object sender, EventArgs e)
        {
            save_as_file();
        }
        private void save_as_file()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Save data
                System.IO.StreamWriter file = new System.IO.StreamWriter(dialog.FileName.ToString());
                file.WriteLine(this.textbox_notepad.Text);
                file.Close();
            }
        }

        private void ToolStripMenuItem_new_Click(object sender, EventArgs e)
        {
            this.textbox_notepad.Text = "";
            filePath = string.Empty;
        }
        private void save_file()
        {
            if (filePath == string.Empty)
            {
                save_as_file();
            }
            else
            {
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    file.WriteLine(this.textbox_notepad.Text);
                    file.Close();
                }
            }
        }
        private void ToolStripMenuItem_save_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            save_file();
        }
    }
}
