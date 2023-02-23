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

namespace Form_homepage
{
    public partial class Form_picture_viewer : Form
    {
        List<string> images = new List<string>();
        public Form_picture_viewer()
        {
            InitializeComponent();
            get_file_name(images);
            
            for(int i = 0; i < images.Count(); i++)
            {
                PictureBox tmp = new PictureBox();
                tmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                tmp.Location = new System.Drawing.Point(24 + 100 * (i % 7), 12 + 100 *(i / 7)); //size
                tmp.Name = i.ToString();
                tmp.Size = new System.Drawing.Size(95, 92);
                tmp.TabIndex = i;
                tmp.TabStop = false;
                tmp.Image = Image.FromFile(images[i]);
                tmp.Click +=  new System.EventHandler((s, e) => show_image(s, e, tmp.TabIndex));
                this.Controls.Add(tmp);
            }
        }
        private void get_file_name(List<string> file_names)
        {
            string folder_path = get_pictures_path();
            DirectoryInfo d = new DirectoryInfo(@folder_path); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                if(file.Extension == ".png" || file.Extension == ".jpg"
                    ||file.Extension == ".jpeg" || file.Extension == ".gif")
                {
                    file_names.Add(Path.Combine(folder_path, file.Name));
                }
            }
        }
        private void show_image(object sender, EventArgs e, int index)
        {
            Form_show_image show = new Form_show_image();
            show.BackgroundImage = Image.FromFile(images[index]);
            show.BackgroundImageLayout = ImageLayout.Stretch;
            show.Show();
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
            ans += "pictures";
            return ans;
        }
    }
}
