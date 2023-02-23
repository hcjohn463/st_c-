namespace Form_homepage
{
    partial class Form_alarm
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
            this.label_alarm_nowtime = new System.Windows.Forms.Label();
            this.groupbox_alarm = new System.Windows.Forms.GroupBox();
            this.checkbox_alarm = new System.Windows.Forms.CheckBox();
            this.textbox_hour = new System.Windows.Forms.TextBox();
            this.label_alarm_lefttitle = new System.Windows.Forms.Label();
            this.label_alarm_uptitle = new System.Windows.Forms.Label();
            this.textbox_alarm_minute = new System.Windows.Forms.TextBox();
            this.textbox_alarm_second = new System.Windows.Forms.TextBox();
            this.label_alarm_hour = new System.Windows.Forms.Label();
            this.label_alarm_minute = new System.Windows.Forms.Label();
            this.label_alarm_second = new System.Windows.Forms.Label();
            this.groupbox_alarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_alarm_nowtime
            // 
            this.label_alarm_nowtime.AutoSize = true;
            this.label_alarm_nowtime.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_nowtime.Location = new System.Drawing.Point(53, 61);
            this.label_alarm_nowtime.Name = "label_alarm_nowtime";
            this.label_alarm_nowtime.Size = new System.Drawing.Size(0, 40);
            this.label_alarm_nowtime.TabIndex = 0;
            // 
            // groupbox_alarm
            // 
            this.groupbox_alarm.Controls.Add(this.label_alarm_second);
            this.groupbox_alarm.Controls.Add(this.label_alarm_minute);
            this.groupbox_alarm.Controls.Add(this.label_alarm_hour);
            this.groupbox_alarm.Controls.Add(this.textbox_alarm_second);
            this.groupbox_alarm.Controls.Add(this.textbox_alarm_minute);
            this.groupbox_alarm.Controls.Add(this.checkbox_alarm);
            this.groupbox_alarm.Controls.Add(this.textbox_hour);
            this.groupbox_alarm.Controls.Add(this.label_alarm_lefttitle);
            this.groupbox_alarm.Controls.Add(this.label_alarm_uptitle);
            this.groupbox_alarm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupbox_alarm.Location = new System.Drawing.Point(142, 123);
            this.groupbox_alarm.Name = "groupbox_alarm";
            this.groupbox_alarm.Size = new System.Drawing.Size(496, 253);
            this.groupbox_alarm.TabIndex = 1;
            this.groupbox_alarm.TabStop = false;
            this.groupbox_alarm.Text = "Select Time";
            // 
            // checkbox_alarm
            // 
            this.checkbox_alarm.AutoSize = true;
            this.checkbox_alarm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkbox_alarm.Location = new System.Drawing.Point(253, 178);
            this.checkbox_alarm.Name = "checkbox_alarm";
            this.checkbox_alarm.Size = new System.Drawing.Size(127, 31);
            this.checkbox_alarm.TabIndex = 3;
            this.checkbox_alarm.Text = "Set Alarm";
            this.checkbox_alarm.UseVisualStyleBackColor = true;
            this.checkbox_alarm.CheckedChanged += new System.EventHandler(this.checkbox_alarm_CheckedChanged);
            // 
            // textbox_hour
            // 
            this.textbox_hour.Location = new System.Drawing.Point(174, 118);
            this.textbox_hour.Name = "textbox_hour";
            this.textbox_hour.Size = new System.Drawing.Size(53, 39);
            this.textbox_hour.TabIndex = 2;
            // 
            // label_alarm_lefttitle
            // 
            this.label_alarm_lefttitle.AutoSize = true;
            this.label_alarm_lefttitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_lefttitle.Location = new System.Drawing.Point(27, 124);
            this.label_alarm_lefttitle.Name = "label_alarm_lefttitle";
            this.label_alarm_lefttitle.Size = new System.Drawing.Size(141, 27);
            this.label_alarm_lefttitle.TabIndex = 1;
            this.label_alarm_lefttitle.Text = "Alarm time：";
            // 
            // label_alarm_uptitle
            // 
            this.label_alarm_uptitle.AutoSize = true;
            this.label_alarm_uptitle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_uptitle.Location = new System.Drawing.Point(248, 50);
            this.label_alarm_uptitle.Name = "label_alarm_uptitle";
            this.label_alarm_uptitle.Size = new System.Drawing.Size(120, 27);
            this.label_alarm_uptitle.TabIndex = 0;
            this.label_alarm_uptitle.Text = "Alarm time";
            // 
            // textbox_alarm_minute
            // 
            this.textbox_alarm_minute.Location = new System.Drawing.Point(272, 118);
            this.textbox_alarm_minute.Name = "textbox_alarm_minute";
            this.textbox_alarm_minute.Size = new System.Drawing.Size(57, 39);
            this.textbox_alarm_minute.TabIndex = 4;
            // 
            // textbox_alarm_second
            // 
            this.textbox_alarm_second.Location = new System.Drawing.Point(374, 118);
            this.textbox_alarm_second.Name = "textbox_alarm_second";
            this.textbox_alarm_second.Size = new System.Drawing.Size(57, 39);
            this.textbox_alarm_second.TabIndex = 5;
            // 
            // label_alarm_hour
            // 
            this.label_alarm_hour.AutoSize = true;
            this.label_alarm_hour.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_hour.Location = new System.Drawing.Point(233, 124);
            this.label_alarm_hour.Name = "label_alarm_hour";
            this.label_alarm_hour.Size = new System.Drawing.Size(33, 27);
            this.label_alarm_hour.TabIndex = 6;
            this.label_alarm_hour.Text = "時";
            // 
            // label_alarm_minute
            // 
            this.label_alarm_minute.AutoSize = true;
            this.label_alarm_minute.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_minute.Location = new System.Drawing.Point(335, 124);
            this.label_alarm_minute.Name = "label_alarm_minute";
            this.label_alarm_minute.Size = new System.Drawing.Size(33, 27);
            this.label_alarm_minute.TabIndex = 7;
            this.label_alarm_minute.Text = "分";
            // 
            // label_alarm_second
            // 
            this.label_alarm_second.AutoSize = true;
            this.label_alarm_second.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_alarm_second.Location = new System.Drawing.Point(437, 124);
            this.label_alarm_second.Name = "label_alarm_second";
            this.label_alarm_second.Size = new System.Drawing.Size(33, 27);
            this.label_alarm_second.TabIndex = 8;
            this.label_alarm_second.Text = "秒";
            // 
            // Form_alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupbox_alarm);
            this.Controls.Add(this.label_alarm_nowtime);
            this.Name = "Form_alarm";
            this.Text = "Form_alarm";
            this.groupbox_alarm.ResumeLayout(false);
            this.groupbox_alarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_alarm_nowtime;
        private System.Windows.Forms.GroupBox groupbox_alarm;
        private System.Windows.Forms.CheckBox checkbox_alarm;
        private System.Windows.Forms.TextBox textbox_hour;
        private System.Windows.Forms.Label label_alarm_lefttitle;
        private System.Windows.Forms.Label label_alarm_uptitle;
        private System.Windows.Forms.Label label_alarm_second;
        private System.Windows.Forms.Label label_alarm_minute;
        private System.Windows.Forms.Label label_alarm_hour;
        private System.Windows.Forms.TextBox textbox_alarm_second;
        private System.Windows.Forms.TextBox textbox_alarm_minute;
    }
}