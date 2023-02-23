namespace Form_homepage
{
    partial class Form_homepage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_hello = new System.Windows.Forms.Button();
            this.button_loan = new System.Windows.Forms.Button();
            this.button_student_struct = new System.Windows.Forms.Button();
            this.button_students_grade = new System.Windows.Forms.Button();
            this.button_students_grade_list = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_pos = new System.Windows.Forms.Button();
            this.button_my_clac = new System.Windows.Forms.Button();
            this.button_xo_game = new System.Windows.Forms.Button();
            this.button_guess_number = new System.Windows.Forms.Button();
            this.button_alarm = new System.Windows.Forms.Button();
            this.button_method = new System.Windows.Forms.Button();
            this.button_for_do_while = new System.Windows.Forms.Button();
            this.button_drawpaint = new System.Windows.Forms.Button();
            this.button_picture_viewer = new System.Windows.Forms.Button();
            this.button_screen_saver = new System.Windows.Forms.Button();
            this.label_homepage_title = new System.Windows.Forms.Label();
            this.button_notepad = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.Location = new System.Drawing.Point(3, 3);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(102, 23);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "hello";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // button_loan
            // 
            this.button_loan.Location = new System.Drawing.Point(3, 32);
            this.button_loan.Name = "button_loan";
            this.button_loan.Size = new System.Drawing.Size(102, 23);
            this.button_loan.TabIndex = 1;
            this.button_loan.Text = "loan";
            this.button_loan.UseVisualStyleBackColor = true;
            this.button_loan.Click += new System.EventHandler(this.button_loan_Click);
            // 
            // button_student_struct
            // 
            this.button_student_struct.Location = new System.Drawing.Point(3, 90);
            this.button_student_struct.Name = "button_student_struct";
            this.button_student_struct.Size = new System.Drawing.Size(102, 23);
            this.button_student_struct.TabIndex = 2;
            this.button_student_struct.Text = "student_struct";
            this.button_student_struct.UseVisualStyleBackColor = true;
            this.button_student_struct.Click += new System.EventHandler(this.button_student_struct_Click);
            // 
            // button_students_grade
            // 
            this.button_students_grade.Location = new System.Drawing.Point(3, 119);
            this.button_students_grade.Name = "button_students_grade";
            this.button_students_grade.Size = new System.Drawing.Size(102, 23);
            this.button_students_grade.TabIndex = 3;
            this.button_students_grade.Text = "students_grade";
            this.button_students_grade.UseVisualStyleBackColor = true;
            this.button_students_grade.Click += new System.EventHandler(this.button_students_grade_Click);
            // 
            // button_students_grade_list
            // 
            this.button_students_grade_list.Location = new System.Drawing.Point(3, 148);
            this.button_students_grade_list.Name = "button_students_grade_list";
            this.button_students_grade_list.Size = new System.Drawing.Size(102, 23);
            this.button_students_grade_list.TabIndex = 4;
            this.button_students_grade_list.Text = "student_grade_list";
            this.button_students_grade_list.UseVisualStyleBackColor = true;
            this.button_students_grade_list.Click += new System.EventHandler(this.button_students_grade_list_Click);
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(139, 47);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(746, 502);
            this.panel_container.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button_hello);
            this.flowLayoutPanel1.Controls.Add(this.button_loan);
            this.flowLayoutPanel1.Controls.Add(this.button_pos);
            this.flowLayoutPanel1.Controls.Add(this.button_student_struct);
            this.flowLayoutPanel1.Controls.Add(this.button_students_grade);
            this.flowLayoutPanel1.Controls.Add(this.button_students_grade_list);
            this.flowLayoutPanel1.Controls.Add(this.button_method);
            this.flowLayoutPanel1.Controls.Add(this.button_my_clac);
            this.flowLayoutPanel1.Controls.Add(this.button_for_do_while);
            this.flowLayoutPanel1.Controls.Add(this.button_xo_game);
            this.flowLayoutPanel1.Controls.Add(this.button_screen_saver);
            this.flowLayoutPanel1.Controls.Add(this.button_notepad);
            this.flowLayoutPanel1.Controls.Add(this.button_drawpaint);
            this.flowLayoutPanel1.Controls.Add(this.button_picture_viewer);
            this.flowLayoutPanel1.Controls.Add(this.button_guess_number);
            this.flowLayoutPanel1.Controls.Add(this.button_alarm);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 502);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button_pos
            // 
            this.button_pos.Location = new System.Drawing.Point(3, 61);
            this.button_pos.Name = "button_pos";
            this.button_pos.Size = new System.Drawing.Size(102, 23);
            this.button_pos.TabIndex = 5;
            this.button_pos.Text = "POS";
            this.button_pos.UseVisualStyleBackColor = true;
            this.button_pos.Click += new System.EventHandler(this.button_pos_Click);
            // 
            // button_my_clac
            // 
            this.button_my_clac.Location = new System.Drawing.Point(3, 206);
            this.button_my_clac.Name = "button_my_clac";
            this.button_my_clac.Size = new System.Drawing.Size(102, 23);
            this.button_my_clac.TabIndex = 6;
            this.button_my_clac.Text = "my_clac";
            this.button_my_clac.UseVisualStyleBackColor = true;
            this.button_my_clac.Click += new System.EventHandler(this.button_my_clac_Click);
            // 
            // button_xo_game
            // 
            this.button_xo_game.Location = new System.Drawing.Point(3, 264);
            this.button_xo_game.Name = "button_xo_game";
            this.button_xo_game.Size = new System.Drawing.Size(102, 23);
            this.button_xo_game.TabIndex = 7;
            this.button_xo_game.Text = "xo_game";
            this.button_xo_game.UseVisualStyleBackColor = true;
            this.button_xo_game.Click += new System.EventHandler(this.button_xo_game_Click);
            // 
            // button_guess_number
            // 
            this.button_guess_number.Location = new System.Drawing.Point(3, 409);
            this.button_guess_number.Name = "button_guess_number";
            this.button_guess_number.Size = new System.Drawing.Size(102, 23);
            this.button_guess_number.TabIndex = 8;
            this.button_guess_number.Text = "考試_Guess";
            this.button_guess_number.UseVisualStyleBackColor = true;
            this.button_guess_number.Click += new System.EventHandler(this.button_guess_number_Click);
            // 
            // button_alarm
            // 
            this.button_alarm.Location = new System.Drawing.Point(3, 438);
            this.button_alarm.Name = "button_alarm";
            this.button_alarm.Size = new System.Drawing.Size(102, 23);
            this.button_alarm.TabIndex = 9;
            this.button_alarm.Text = "考試_Alarm";
            this.button_alarm.UseVisualStyleBackColor = true;
            this.button_alarm.Click += new System.EventHandler(this.button_alarm_Click);
            // 
            // button_method
            // 
            this.button_method.Location = new System.Drawing.Point(3, 177);
            this.button_method.Name = "button_method";
            this.button_method.Size = new System.Drawing.Size(102, 23);
            this.button_method.TabIndex = 10;
            this.button_method.Text = "Method";
            this.button_method.UseVisualStyleBackColor = true;
            this.button_method.Click += new System.EventHandler(this.button_method_Click);
            // 
            // button_for_do_while
            // 
            this.button_for_do_while.Location = new System.Drawing.Point(3, 235);
            this.button_for_do_while.Name = "button_for_do_while";
            this.button_for_do_while.Size = new System.Drawing.Size(102, 23);
            this.button_for_do_while.TabIndex = 11;
            this.button_for_do_while.Text = "for_do_while";
            this.button_for_do_while.UseVisualStyleBackColor = true;
            this.button_for_do_while.Click += new System.EventHandler(this.button_for_do_while_Click);
            // 
            // button_drawpaint
            // 
            this.button_drawpaint.Location = new System.Drawing.Point(3, 351);
            this.button_drawpaint.Name = "button_drawpaint";
            this.button_drawpaint.Size = new System.Drawing.Size(102, 23);
            this.button_drawpaint.TabIndex = 12;
            this.button_drawpaint.Text = "小畫家";
            this.button_drawpaint.UseVisualStyleBackColor = true;
            this.button_drawpaint.Click += new System.EventHandler(this.button_drawpaint_Click);
            // 
            // button_picture_viewer
            // 
            this.button_picture_viewer.Location = new System.Drawing.Point(3, 380);
            this.button_picture_viewer.Name = "button_picture_viewer";
            this.button_picture_viewer.Size = new System.Drawing.Size(102, 23);
            this.button_picture_viewer.TabIndex = 13;
            this.button_picture_viewer.Text = "picture viewer";
            this.button_picture_viewer.UseVisualStyleBackColor = true;
            this.button_picture_viewer.Click += new System.EventHandler(this.button_picture_viewer_Click);
            // 
            // button_screen_saver
            // 
            this.button_screen_saver.Location = new System.Drawing.Point(3, 293);
            this.button_screen_saver.Name = "button_screen_saver";
            this.button_screen_saver.Size = new System.Drawing.Size(102, 23);
            this.button_screen_saver.TabIndex = 14;
            this.button_screen_saver.Text = "screen saver";
            this.button_screen_saver.UseVisualStyleBackColor = true;
            this.button_screen_saver.Click += new System.EventHandler(this.button_screen_saver_Click);
            // 
            // label_homepage_title
            // 
            this.label_homepage_title.AutoSize = true;
            this.label_homepage_title.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_homepage_title.Location = new System.Drawing.Point(428, 9);
            this.label_homepage_title.Name = "label_homepage_title";
            this.label_homepage_title.Size = new System.Drawing.Size(104, 35);
            this.label_homepage_title.TabIndex = 7;
            this.label_homepage_title.Text = "C#作業";
            // 
            // button_notepad
            // 
            this.button_notepad.Location = new System.Drawing.Point(3, 322);
            this.button_notepad.Name = "button_notepad";
            this.button_notepad.Size = new System.Drawing.Size(102, 23);
            this.button_notepad.TabIndex = 15;
            this.button_notepad.Text = "Notepad";
            this.button_notepad.UseVisualStyleBackColor = true;
            this.button_notepad.Click += new System.EventHandler(this.button_notepad_Click);
            // 
            // Form_homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 567);
            this.Controls.Add(this.label_homepage_title);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_container);
            this.Name = "Form_homepage";
            this.Text = " HomePage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.Button button_loan;
        private System.Windows.Forms.Button button_student_struct;
        private System.Windows.Forms.Button button_students_grade;
        private System.Windows.Forms.Button button_students_grade_list;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_homepage_title;
        private System.Windows.Forms.Button button_pos;
        private System.Windows.Forms.Button button_my_clac;
        private System.Windows.Forms.Button button_xo_game;
        private System.Windows.Forms.Button button_guess_number;
        private System.Windows.Forms.Button button_alarm;
        private System.Windows.Forms.Button button_method;
        private System.Windows.Forms.Button button_for_do_while;
        private System.Windows.Forms.Button button_drawpaint;
        private System.Windows.Forms.Button button_picture_viewer;
        private System.Windows.Forms.Button button_screen_saver;
        private System.Windows.Forms.Button button_notepad;
    }
}

