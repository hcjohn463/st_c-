using System.Collections.Generic;

namespace Form_homepage
{
    partial class Form_students_grade_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_students_grade_statics = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_final = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_list_chinese = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_list_english = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_list_math = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_list_name = new System.Windows.Forms.TextBox();
            this.label_students_grade_list_chinese = new System.Windows.Forms.Label();
            this.label_students_grade_list_english = new System.Windows.Forms.Label();
            this.label_students_grade_list_math = new System.Windows.Forms.Label();
            this.label_students_grade_list_name = new System.Windows.Forms.Label();
            this.button_students_grade_list_downinsert = new System.Windows.Forms.Button();
            this.button_students_grade_list_upinsert = new System.Windows.Forms.Button();
            this.button_students_grade_list_remove = new System.Windows.Forms.Button();
            this.button_students_grade_clear = new System.Windows.Forms.Button();
            this.button_students_grade_list_total = new System.Windows.Forms.Button();
            this.label_search_chinese_range = new System.Windows.Forms.Label();
            this.textbox_chinese_down = new System.Windows.Forms.TextBox();
            this.textbox_chinese_up = new System.Windows.Forms.TextBox();
            this.label_chinese_dash = new System.Windows.Forms.Label();
            this.button_chinese_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_students_grade_statics
            // 
            this.textbox_students_grade_statics.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_statics.Location = new System.Drawing.Point(185, 24);
            this.textbox_students_grade_statics.Multiline = true;
            this.textbox_students_grade_statics.Name = "textbox_students_grade_statics";
            this.textbox_students_grade_statics.ReadOnly = true;
            this.textbox_students_grade_statics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_students_grade_statics.Size = new System.Drawing.Size(528, 275);
            this.textbox_students_grade_statics.TabIndex = 12;
            this.textbox_students_grade_statics.Text = "姓名   國文   英文   數學    總分    平均    最低    最高    \r\n";
            // 
            // textbox_students_grade_final
            // 
            this.textbox_students_grade_final.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_final.Location = new System.Drawing.Point(185, 305);
            this.textbox_students_grade_final.Multiline = true;
            this.textbox_students_grade_final.Name = "textbox_students_grade_final";
            this.textbox_students_grade_final.ReadOnly = true;
            this.textbox_students_grade_final.Size = new System.Drawing.Size(528, 100);
            this.textbox_students_grade_final.TabIndex = 15;
            // 
            // textbox_students_grade_list_chinese
            // 
            this.textbox_students_grade_list_chinese.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_list_chinese.Location = new System.Drawing.Point(85, 65);
            this.textbox_students_grade_list_chinese.Name = "textbox_students_grade_list_chinese";
            this.textbox_students_grade_list_chinese.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_list_chinese.TabIndex = 23;
            this.textbox_students_grade_list_chinese.Text = "0";
            this.textbox_students_grade_list_chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_list_english
            // 
            this.textbox_students_grade_list_english.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_list_english.Location = new System.Drawing.Point(85, 109);
            this.textbox_students_grade_list_english.Name = "textbox_students_grade_list_english";
            this.textbox_students_grade_list_english.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_list_english.TabIndex = 22;
            this.textbox_students_grade_list_english.Text = "0";
            this.textbox_students_grade_list_english.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_list_math
            // 
            this.textbox_students_grade_list_math.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_list_math.Location = new System.Drawing.Point(85, 155);
            this.textbox_students_grade_list_math.Name = "textbox_students_grade_list_math";
            this.textbox_students_grade_list_math.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_list_math.TabIndex = 21;
            this.textbox_students_grade_list_math.Text = "0";
            this.textbox_students_grade_list_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_list_name
            // 
            this.textbox_students_grade_list_name.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_list_name.Location = new System.Drawing.Point(85, 24);
            this.textbox_students_grade_list_name.Name = "textbox_students_grade_list_name";
            this.textbox_students_grade_list_name.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_list_name.TabIndex = 20;
            this.textbox_students_grade_list_name.Text = "0";
            this.textbox_students_grade_list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_students_grade_list_chinese
            // 
            this.label_students_grade_list_chinese.AutoSize = true;
            this.label_students_grade_list_chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_list_chinese.Location = new System.Drawing.Point(12, 68);
            this.label_students_grade_list_chinese.Name = "label_students_grade_list_chinese";
            this.label_students_grade_list_chinese.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_list_chinese.TabIndex = 19;
            this.label_students_grade_list_chinese.Text = "國文：";
            // 
            // label_students_grade_list_english
            // 
            this.label_students_grade_list_english.AutoSize = true;
            this.label_students_grade_list_english.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_list_english.Location = new System.Drawing.Point(12, 112);
            this.label_students_grade_list_english.Name = "label_students_grade_list_english";
            this.label_students_grade_list_english.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_list_english.TabIndex = 18;
            this.label_students_grade_list_english.Text = "英文：";
            // 
            // label_students_grade_list_math
            // 
            this.label_students_grade_list_math.AutoSize = true;
            this.label_students_grade_list_math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_list_math.Location = new System.Drawing.Point(12, 158);
            this.label_students_grade_list_math.Name = "label_students_grade_list_math";
            this.label_students_grade_list_math.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_list_math.TabIndex = 17;
            this.label_students_grade_list_math.Text = "數學：";
            // 
            // label_students_grade_list_name
            // 
            this.label_students_grade_list_name.AutoSize = true;
            this.label_students_grade_list_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_list_name.Location = new System.Drawing.Point(12, 27);
            this.label_students_grade_list_name.Name = "label_students_grade_list_name";
            this.label_students_grade_list_name.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_list_name.TabIndex = 16;
            this.label_students_grade_list_name.Text = "姓名：";
            // 
            // button_students_grade_list_downinsert
            // 
            this.button_students_grade_list_downinsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_list_downinsert.Location = new System.Drawing.Point(16, 207);
            this.button_students_grade_list_downinsert.Name = "button_students_grade_list_downinsert";
            this.button_students_grade_list_downinsert.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_list_downinsert.TabIndex = 24;
            this.button_students_grade_list_downinsert.Text = "加入學生資料";
            this.button_students_grade_list_downinsert.UseVisualStyleBackColor = true;
            this.button_students_grade_list_downinsert.Click += new System.EventHandler(this.button_students_grade_list_downinsert_Click);
            // 
            // button_students_grade_list_upinsert
            // 
            this.button_students_grade_list_upinsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_list_upinsert.Location = new System.Drawing.Point(16, 241);
            this.button_students_grade_list_upinsert.Name = "button_students_grade_list_upinsert";
            this.button_students_grade_list_upinsert.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_list_upinsert.TabIndex = 25;
            this.button_students_grade_list_upinsert.Text = "插入儲存資料";
            this.button_students_grade_list_upinsert.UseVisualStyleBackColor = true;
            this.button_students_grade_list_upinsert.Click += new System.EventHandler(this.button_students_grade_list_upinsert_Click);
            // 
            // button_students_grade_list_remove
            // 
            this.button_students_grade_list_remove.Enabled = false;
            this.button_students_grade_list_remove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_list_remove.Location = new System.Drawing.Point(16, 275);
            this.button_students_grade_list_remove.Name = "button_students_grade_list_remove";
            this.button_students_grade_list_remove.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_list_remove.TabIndex = 26;
            this.button_students_grade_list_remove.Text = "移除資料";
            this.button_students_grade_list_remove.UseVisualStyleBackColor = true;
            this.button_students_grade_list_remove.Click += new System.EventHandler(this.button_students_grade_list_remove_Click);
            // 
            // button_students_grade_clear
            // 
            this.button_students_grade_clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_clear.Location = new System.Drawing.Point(16, 309);
            this.button_students_grade_clear.Name = "button_students_grade_clear";
            this.button_students_grade_clear.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_clear.TabIndex = 27;
            this.button_students_grade_clear.Text = "清除所有資料";
            this.button_students_grade_clear.UseVisualStyleBackColor = true;
            this.button_students_grade_clear.Click += new System.EventHandler(this.button_students_grade_clear_Click);
            // 
            // button_students_grade_list_total
            // 
            this.button_students_grade_list_total.Enabled = false;
            this.button_students_grade_list_total.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_list_total.Location = new System.Drawing.Point(577, 405);
            this.button_students_grade_list_total.Name = "button_students_grade_list_total";
            this.button_students_grade_list_total.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_list_total.TabIndex = 28;
            this.button_students_grade_list_total.Text = "各科統計";
            this.button_students_grade_list_total.UseVisualStyleBackColor = true;
            this.button_students_grade_list_total.Click += new System.EventHandler(this.button_students_grade_list_total_Click);
            // 
            // label_search_chinese_range
            // 
            this.label_search_chinese_range.AutoSize = true;
            this.label_search_chinese_range.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_search_chinese_range.Location = new System.Drawing.Point(26, 348);
            this.label_search_chinese_range.Name = "label_search_chinese_range";
            this.label_search_chinese_range.Size = new System.Drawing.Size(144, 19);
            this.label_search_chinese_range.TabIndex = 29;
            this.label_search_chinese_range.Text = "搜尋國文成績範圍：";
            // 
            // textbox_chinese_down
            // 
            this.textbox_chinese_down.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_chinese_down.Location = new System.Drawing.Point(16, 370);
            this.textbox_chinese_down.Name = "textbox_chinese_down";
            this.textbox_chinese_down.Size = new System.Drawing.Size(63, 29);
            this.textbox_chinese_down.TabIndex = 30;
            this.textbox_chinese_down.Text = "0";
            this.textbox_chinese_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_chinese_up
            // 
            this.textbox_chinese_up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_chinese_up.Location = new System.Drawing.Point(107, 370);
            this.textbox_chinese_up.Name = "textbox_chinese_up";
            this.textbox_chinese_up.Size = new System.Drawing.Size(63, 29);
            this.textbox_chinese_up.TabIndex = 31;
            this.textbox_chinese_up.Text = "100";
            this.textbox_chinese_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_chinese_dash
            // 
            this.label_chinese_dash.AutoSize = true;
            this.label_chinese_dash.BackColor = System.Drawing.Color.Transparent;
            this.label_chinese_dash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_chinese_dash.Location = new System.Drawing.Point(85, 373);
            this.label_chinese_dash.Name = "label_chinese_dash";
            this.label_chinese_dash.Size = new System.Drawing.Size(16, 20);
            this.label_chinese_dash.TabIndex = 32;
            this.label_chinese_dash.Text = "-";
            // 
            // button_chinese_search
            // 
            this.button_chinese_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_chinese_search.Location = new System.Drawing.Point(16, 405);
            this.button_chinese_search.Name = "button_chinese_search";
            this.button_chinese_search.Size = new System.Drawing.Size(154, 33);
            this.button_chinese_search.TabIndex = 33;
            this.button_chinese_search.Text = "SEARCH";
            this.button_chinese_search.UseVisualStyleBackColor = true;
            this.button_chinese_search.Click += new System.EventHandler(this.button_chinese_search_Click);
            // 
            // Form_students_grade_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_chinese_search);
            this.Controls.Add(this.label_chinese_dash);
            this.Controls.Add(this.textbox_chinese_up);
            this.Controls.Add(this.textbox_chinese_down);
            this.Controls.Add(this.label_search_chinese_range);
            this.Controls.Add(this.button_students_grade_list_total);
            this.Controls.Add(this.button_students_grade_clear);
            this.Controls.Add(this.button_students_grade_list_remove);
            this.Controls.Add(this.button_students_grade_list_upinsert);
            this.Controls.Add(this.button_students_grade_list_downinsert);
            this.Controls.Add(this.textbox_students_grade_list_chinese);
            this.Controls.Add(this.textbox_students_grade_list_english);
            this.Controls.Add(this.textbox_students_grade_list_math);
            this.Controls.Add(this.textbox_students_grade_list_name);
            this.Controls.Add(this.label_students_grade_list_chinese);
            this.Controls.Add(this.label_students_grade_list_english);
            this.Controls.Add(this.label_students_grade_list_math);
            this.Controls.Add(this.label_students_grade_list_name);
            this.Controls.Add(this.textbox_students_grade_final);
            this.Controls.Add(this.textbox_students_grade_statics);
            this.Name = "Form_students_grade_list";
            this.Text = "Form_students_grade_list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_students_grade_statics;
        private System.Windows.Forms.TextBox textbox_students_grade_final;
        private System.Windows.Forms.TextBox textbox_students_grade_list_chinese;
        private System.Windows.Forms.TextBox textbox_students_grade_list_english;
        private System.Windows.Forms.TextBox textbox_students_grade_list_math;
        private System.Windows.Forms.TextBox textbox_students_grade_list_name;
        private System.Windows.Forms.Label label_students_grade_list_chinese;
        private System.Windows.Forms.Label label_students_grade_list_english;
        private System.Windows.Forms.Label label_students_grade_list_math;
        private System.Windows.Forms.Label label_students_grade_list_name;
        private System.Windows.Forms.Button button_students_grade_list_downinsert;
        private System.Windows.Forms.Button button_students_grade_list_upinsert;
        private System.Windows.Forms.Button button_students_grade_list_remove;
        private System.Windows.Forms.Button button_students_grade_clear;
        private System.Windows.Forms.Button button_students_grade_list_total;

        //default
        public string name = "";
        List<string> statics = new List<string>() { "姓名   國文   英文   數學    總分    平均    最低    最高    \r\n" };
        public double chinese, english, math = 0;
        List<string> names = new List<string>();
        List<double> chinese_grades = new List<double>();
        List<double> english_grades = new List<double>();
        List<double> math_grades = new List<double>();
        private System.Windows.Forms.Label label_search_chinese_range;
        private System.Windows.Forms.TextBox textbox_chinese_down;
        private System.Windows.Forms.TextBox textbox_chinese_up;
        private System.Windows.Forms.Label label_chinese_dash;
        private System.Windows.Forms.Button button_chinese_search;
    }
}