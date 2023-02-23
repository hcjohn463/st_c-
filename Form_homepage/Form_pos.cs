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
    public partial class Form_pos : Form
    {
        public Form_pos()
        {
            InitializeComponent();
        }
        int beer_number = 0;
        int tequila_number = 0;
        int whisky_number = 0;
        int wine_number = 0;
        int total_price = 0;
        List<string> pos_list = new List<string>();

        private void button_pos_beer_Click(object sender, EventArgs e)
        {
            beer_number++;
            total_price += 120;
            show_list();
            show_price();
        }

        private void button_pos_tequila_Click(object sender, EventArgs e)
        {
            tequila_number++;
            total_price += 180;
            show_list();
            show_price();
        }

        private void button_pos_whisky_Click(object sender, EventArgs e)
        {
            whisky_number++;
            total_price += 350;
            show_list();
            show_price();
        }

        private void button_pos_wine_Click(object sender, EventArgs e)
        {
            wine_number++;
            total_price += 320;
            show_list();
            show_price();
        }

        private void show_list()
        {
            pos_list.Clear();
            if (beer_number > 0)
            {
                string beer_line = "啤酒Beer x" + beer_number + ",共NT$ " + beer_number * 120 + " 元\r\n";
                pos_list.Add(beer_line);
            }
            if(tequila_number > 0)
            {
                string tequila_line = "龍舌蘭Tequila x" + tequila_number + ",共NT$ " + tequila_number * 180 + " 元\r\n";
                pos_list.Add(tequila_line);
            }
            if(whisky_number > 0)
            {
                string whisky_line = "威士忌Whisky x" + whisky_number + ",共NT$ " + whisky_number * 350 + " 元\r\n";
                pos_list.Add(whisky_line);
            }
            if(wine_number > 0)
            {
                string wine_line = "紅酒Wine x" + wine_number + ",共NT$ " + wine_number * 320 + " 元\r\n";
                pos_list.Add(wine_line);
            }
            string result = "";
            for(int i = 0; i < this.pos_list.Count(); i++)
            {
                result += pos_list[i];
            }
            this.textbox_pos_list.Text = result;
        }
        private void show_price()
        {
            this.textbox_pos_total_price.Text = "NT$ " + total_price.ToString();
        }

        private void button_pos_clear_list_Click(object sender, EventArgs e)
        {
            beer_number = 0;
            tequila_number = 0;
            whisky_number = 0;
            wine_number = 0;
            total_price = 0;
            show_list();
            this.textbox_pos_list.Text = "尚未點餐";
            show_price();
        }
        private void button_pos_paycash_Click(object sender, EventArgs e)
        {
            check_out(1);
        }
        private void check_out(double discount)
        {
            if (total_price == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string text = "總金額：NT$ " + total_price.ToString();
                if(discount != 1)
                {
                    int discount_price = (int)(total_price * discount);
                    text += "\r\n折扣後金額：NT$ " + discount_price.ToString();
                }
                MessageBox.Show(text, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void button_pos_paycard_Click(object sender, EventArgs e)
        {
            check_out(0.9);
        }
    }
}
