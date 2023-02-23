using System;
using System.Collections.Generic;

namespace Form_homepage
{
    partial class Form_students_grade
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
            this.label_students_grade_name = new System.Windows.Forms.Label();
            this.label_students_grade_math = new System.Windows.Forms.Label();
            this.label_students_grade_english = new System.Windows.Forms.Label();
            this.label_students_grade_chinese = new System.Windows.Forms.Label();
            this.textbox_students_grade_name = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_math = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_english = new System.Windows.Forms.TextBox();
            this.textbox_students_grade_chinese = new System.Windows.Forms.TextBox();
            this.button_students_grade_insert = new System.Windows.Forms.Button();
            this.button_students_grade_random_insert = new System.Windows.Forms.Button();
            this.button_students_grade_total = new System.Windows.Forms.Button();
            this.textbox_students_grade_statics = new System.Windows.Forms.TextBox();
            this.button_students_grade_random_insert20 = new System.Windows.Forms.Button();
            this.button_students_grade_reset = new System.Windows.Forms.Button();
            this.textbox_students_grade_final = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_students_grade_name
            // 
            this.label_students_grade_name.AutoSize = true;
            this.label_students_grade_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_name.Location = new System.Drawing.Point(12, 24);
            this.label_students_grade_name.Name = "label_students_grade_name";
            this.label_students_grade_name.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_name.TabIndex = 0;
            this.label_students_grade_name.Text = "姓名：";
            // 
            // label_students_grade_math
            // 
            this.label_students_grade_math.AutoSize = true;
            this.label_students_grade_math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_math.Location = new System.Drawing.Point(12, 155);
            this.label_students_grade_math.Name = "label_students_grade_math";
            this.label_students_grade_math.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_math.TabIndex = 1;
            this.label_students_grade_math.Text = "數學：";
            // 
            // label_students_grade_english
            // 
            this.label_students_grade_english.AutoSize = true;
            this.label_students_grade_english.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_english.Location = new System.Drawing.Point(12, 109);
            this.label_students_grade_english.Name = "label_students_grade_english";
            this.label_students_grade_english.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_english.TabIndex = 2;
            this.label_students_grade_english.Text = "英文：";
            // 
            // label_students_grade_chinese
            // 
            this.label_students_grade_chinese.AutoSize = true;
            this.label_students_grade_chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_students_grade_chinese.Location = new System.Drawing.Point(12, 65);
            this.label_students_grade_chinese.Name = "label_students_grade_chinese";
            this.label_students_grade_chinese.Size = new System.Drawing.Size(67, 24);
            this.label_students_grade_chinese.TabIndex = 3;
            this.label_students_grade_chinese.Text = "國文：";
            // 
            // textbox_students_grade_name
            // 
            this.textbox_students_grade_name.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_name.Location = new System.Drawing.Point(85, 21);
            this.textbox_students_grade_name.Name = "textbox_students_grade_name";
            this.textbox_students_grade_name.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_name.TabIndex = 4;
            this.textbox_students_grade_name.Text = "0";
            this.textbox_students_grade_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_math
            // 
            this.textbox_students_grade_math.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_math.Location = new System.Drawing.Point(85, 152);
            this.textbox_students_grade_math.Name = "textbox_students_grade_math";
            this.textbox_students_grade_math.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_math.TabIndex = 5;
            this.textbox_students_grade_math.Text = "0";
            this.textbox_students_grade_math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_english
            // 
            this.textbox_students_grade_english.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_english.Location = new System.Drawing.Point(85, 106);
            this.textbox_students_grade_english.Name = "textbox_students_grade_english";
            this.textbox_students_grade_english.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_english.TabIndex = 6;
            this.textbox_students_grade_english.Text = "0";
            this.textbox_students_grade_english.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_students_grade_chinese
            // 
            this.textbox_students_grade_chinese.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_chinese.Location = new System.Drawing.Point(85, 62);
            this.textbox_students_grade_chinese.Name = "textbox_students_grade_chinese";
            this.textbox_students_grade_chinese.Size = new System.Drawing.Size(67, 27);
            this.textbox_students_grade_chinese.TabIndex = 7;
            this.textbox_students_grade_chinese.Text = "0";
            this.textbox_students_grade_chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_students_grade_insert
            // 
            this.button_students_grade_insert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_insert.Location = new System.Drawing.Point(16, 198);
            this.button_students_grade_insert.Name = "button_students_grade_insert";
            this.button_students_grade_insert.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_insert.TabIndex = 8;
            this.button_students_grade_insert.Text = "加入學生資料";
            this.button_students_grade_insert.UseVisualStyleBackColor = true;
            this.button_students_grade_insert.Click += new System.EventHandler(this.button_students_grade_insert_Click);
            // 
            // button_students_grade_random_insert
            // 
            this.button_students_grade_random_insert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_random_insert.Location = new System.Drawing.Point(16, 232);
            this.button_students_grade_random_insert.Name = "button_students_grade_random_insert";
            this.button_students_grade_random_insert.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_random_insert.TabIndex = 9;
            this.button_students_grade_random_insert.Text = "隨機儲存資料";
            this.button_students_grade_random_insert.UseVisualStyleBackColor = true;
            this.button_students_grade_random_insert.Click += new System.EventHandler(this.button_students_grade_random_insert_Click);
            // 
            // button_students_grade_total
            // 
            this.button_students_grade_total.Enabled = false;
            this.button_students_grade_total.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_total.Location = new System.Drawing.Point(16, 275);
            this.button_students_grade_total.Name = "button_students_grade_total";
            this.button_students_grade_total.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_total.TabIndex = 10;
            this.button_students_grade_total.Text = "各科統計";
            this.button_students_grade_total.UseVisualStyleBackColor = true;
            this.button_students_grade_total.Click += new System.EventHandler(this.button_students_grade_total_Click);
            // 
            // textbox_students_grade_statics
            // 
            this.textbox_students_grade_statics.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_statics.Location = new System.Drawing.Point(180, 21);
            this.textbox_students_grade_statics.Multiline = true;
            this.textbox_students_grade_statics.Name = "textbox_students_grade_statics";
            this.textbox_students_grade_statics.ReadOnly = true;
            this.textbox_students_grade_statics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_students_grade_statics.Size = new System.Drawing.Size(536, 307);
            this.textbox_students_grade_statics.TabIndex = 11;
            this.textbox_students_grade_statics.Text = "姓名   國文   英文   數學    總分    平均    最低    最高    \r\n";
            // 
            // button_students_grade_random_insert20
            // 
            this.button_students_grade_random_insert20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_random_insert20.Location = new System.Drawing.Point(16, 385);
            this.button_students_grade_random_insert20.Name = "button_students_grade_random_insert20";
            this.button_students_grade_random_insert20.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_random_insert20.TabIndex = 12;
            this.button_students_grade_random_insert20.Text = "隨機加入20筆";
            this.button_students_grade_random_insert20.UseVisualStyleBackColor = true;
            this.button_students_grade_random_insert20.Click += new System.EventHandler(this.button_students_grade_random_insert20_Click);
            // 
            // button_students_grade_reset
            // 
            this.button_students_grade_reset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_students_grade_reset.Location = new System.Drawing.Point(16, 351);
            this.button_students_grade_reset.Name = "button_students_grade_reset";
            this.button_students_grade_reset.Size = new System.Drawing.Size(136, 28);
            this.button_students_grade_reset.TabIndex = 13;
            this.button_students_grade_reset.Text = "重設所有資料";
            this.button_students_grade_reset.UseVisualStyleBackColor = true;
            this.button_students_grade_reset.Click += new System.EventHandler(this.button_students_grade_reset_Click);
            // 
            // textbox_students_grade_final
            // 
            this.textbox_students_grade_final.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_students_grade_final.Location = new System.Drawing.Point(180, 334);
            this.textbox_students_grade_final.Multiline = true;
            this.textbox_students_grade_final.Name = "textbox_students_grade_final";
            this.textbox_students_grade_final.ReadOnly = true;
            this.textbox_students_grade_final.Size = new System.Drawing.Size(536, 104);
            this.textbox_students_grade_final.TabIndex = 14;
            // 
            // Form_students_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox_students_grade_final);
            this.Controls.Add(this.button_students_grade_reset);
            this.Controls.Add(this.button_students_grade_random_insert20);
            this.Controls.Add(this.textbox_students_grade_statics);
            this.Controls.Add(this.button_students_grade_total);
            this.Controls.Add(this.button_students_grade_random_insert);
            this.Controls.Add(this.button_students_grade_insert);
            this.Controls.Add(this.textbox_students_grade_chinese);
            this.Controls.Add(this.textbox_students_grade_english);
            this.Controls.Add(this.textbox_students_grade_math);
            this.Controls.Add(this.textbox_students_grade_name);
            this.Controls.Add(this.label_students_grade_chinese);
            this.Controls.Add(this.label_students_grade_english);
            this.Controls.Add(this.label_students_grade_math);
            this.Controls.Add(this.label_students_grade_name);
            this.Name = "Form_students_grade";
            this.Text = "Form_students_grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_students_grade_name;
        private System.Windows.Forms.Label label_students_grade_math;
        private System.Windows.Forms.Label label_students_grade_english;
        private System.Windows.Forms.Label label_students_grade_chinese;
        private System.Windows.Forms.TextBox textbox_students_grade_name;
        private System.Windows.Forms.TextBox textbox_students_grade_math;
        private System.Windows.Forms.TextBox textbox_students_grade_english;
        private System.Windows.Forms.TextBox textbox_students_grade_chinese;
        private System.Windows.Forms.Button button_students_grade_insert;
        private System.Windows.Forms.Button button_students_grade_random_insert;
        private System.Windows.Forms.Button button_students_grade_total;
        private System.Windows.Forms.TextBox textbox_students_grade_statics;
        private System.Windows.Forms.Button button_students_grade_random_insert20;
        private System.Windows.Forms.Button button_students_grade_reset;
        private System.Windows.Forms.TextBox textbox_students_grade_final;

        //default
        public string name = "";
        public double chinese, english, math = 0;
        int random_number = 0;
        List<string> names = new List<string>();
        List<double> chinese_grades = new List<double>();
        List<double> english_grades = new List<double>();
        List<double> math_grades = new List<double>();
    }
}