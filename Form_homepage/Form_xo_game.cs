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
    public partial class Form_xo_game : Form
    {
        public Form_xo_game()
        {
            InitializeComponent();
            construct_checkboard();
        }
        int player = 1; // 1 = X, 0 = O ,-1 = NA
        int count = 0;
        List<List<int>> check_board = new List<List<int>>();
        private void construct_checkboard()
        {
            check_board.Clear();
            for(int i = 0; i < 3; i++)
            {
                List<int> row = new List<int>() { -1, -1, -1 };
                check_board.Add(row);
            }
        }
        private void button_xo_game_11_Click(object sender, EventArgs e)
        {
            this.button_xo_game_11.Text = get_player_symbol().ToString();
            check_board[0][0] = player;
            this.button_xo_game_11.Enabled = false;
            check_win();
            count++;
        }
        private void change_player()
        {
            if (player == 1)
            {
                player = 0;
            }
            else
            {
                player = 1;
            }
        }
        private char get_player_symbol()
        {
            if(this.player == 1)
            {
                return 'X';
            }
            return 'O';
        }

        private void button_xo_game_12_Click(object sender, EventArgs e)
        {
            this.button_xo_game_12.Text = get_player_symbol().ToString();
            check_board[0][1] = player;
            this.button_xo_game_12.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_13_Click(object sender, EventArgs e)
        {
            this.button_xo_game_13.Text = get_player_symbol().ToString();
            check_board[0][2] = player;
            this.button_xo_game_13.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_21_Click(object sender, EventArgs e)
        {
            this.button_xo_game_21.Text = get_player_symbol().ToString();
            check_board[1][0] = player;
            this.button_xo_game_21.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_22_Click(object sender, EventArgs e)
        {
            this.button_xo_game_22.Text = get_player_symbol().ToString();
            check_board[1][1] = player;
            this.button_xo_game_22.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_23_Click(object sender, EventArgs e)
        {
            this.button_xo_game_23.Text = get_player_symbol().ToString();
            check_board[1][2] = player;
            this.button_xo_game_23.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_31_Click(object sender, EventArgs e)
        {
            this.button_xo_game_31.Text = get_player_symbol().ToString();
            check_board[2][0] = player;
            this.button_xo_game_31.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_32_Click(object sender, EventArgs e)
        {
            this.button_xo_game_32.Text = get_player_symbol().ToString();
            check_board[2][1] = player;
            this.button_xo_game_32.Enabled = false;
            check_win();
            count++;
        }

        private void button_xo_game_33_Click(object sender, EventArgs e)
        {
            this.button_xo_game_33.Text = get_player_symbol().ToString();
            check_board[2][2] = player;
            this.button_xo_game_33.Enabled = false;
            check_win();
            count++;
        }
        private void check_win()
        {
            if ((check_board[0][0] != -1 && check_board[0][0] == check_board[1][0] && check_board[0][0] == check_board[2][0])
                || (check_board[0][1] != -1 && check_board[0][1] == check_board[1][1] && check_board[0][1] == check_board[2][1])
                || (check_board[0][2] != -1 && check_board[0][2] == check_board[1][2] && check_board[0][2] == check_board[2][2])
                || (check_board[0][0] != -1 && check_board[0][0] == check_board[0][1] && check_board[0][0] == check_board[0][2])
                || (check_board[1][0] != -1 && check_board[1][0] == check_board[1][1] && check_board[1][0] == check_board[1][2])
                || (check_board[2][0] != -1 && check_board[2][0] == check_board[2][1] && check_board[2][0] == check_board[2][2])
                || (check_board[0][0] != -1 && check_board[0][0] == check_board[1][1] && check_board[0][0] == check_board[2][2])
                || (check_board[2][0] != -1 && check_board[2][0] == check_board[1][1] && check_board[2][0] == check_board[0][2]))
            {
                char winner = get_player_symbol();
                MessageBox.Show(winner  + "手獲勝！", "完局！", MessageBoxButtons.OK);
                clear();
            }
            else
            {
                //平手
                if (count == 9)
                {
                    MessageBox.Show("平手！按下確定從新開始", "完局", MessageBoxButtons.OK);
                    clear();
                }
                else
                {
                    change_player();
                }
            }
        }

        private void button_xo_game_reset_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            player = 1;
            count = 0;
            construct_checkboard();
            this.button_xo_game_11.Text = "";
            this.button_xo_game_12.Text = "";
            this.button_xo_game_13.Text = "";
            this.button_xo_game_21.Text = "";
            this.button_xo_game_22.Text = "";
            this.button_xo_game_23.Text = "";
            this.button_xo_game_31.Text = "";
            this.button_xo_game_32.Text = "";
            this.button_xo_game_33.Text = "";
            this.button_xo_game_11.Enabled = true;
            this.button_xo_game_12.Enabled = true;
            this.button_xo_game_13.Enabled = true;
            this.button_xo_game_21.Enabled = true;
            this.button_xo_game_22.Enabled = true;
            this.button_xo_game_23.Enabled = true;
            this.button_xo_game_31.Enabled = true;
            this.button_xo_game_32.Enabled = true;
            this.button_xo_game_33.Enabled = true;
        }

        private void button_xo_game_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_xo_game_KeyDown(object sender, KeyEventArgs e)
        {
            //form key_preview = true
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.R)
            {
                clear();
            }
        }
    }
}
