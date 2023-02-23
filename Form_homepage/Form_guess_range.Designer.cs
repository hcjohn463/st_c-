namespace Form_homepage
{
    partial class Form_guess_range
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
            this.label_guess_range_title = new System.Windows.Forms.Label();
            this.button_guess_range_enter = new System.Windows.Forms.Button();
            this.button_guess_range_cancel = new System.Windows.Forms.Button();
            this.textbox_guess_range_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_guess_range_title
            // 
            this.label_guess_range_title.AutoSize = true;
            this.label_guess_range_title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_guess_range_title.Location = new System.Drawing.Point(12, 40);
            this.label_guess_range_title.Name = "label_guess_range_title";
            this.label_guess_range_title.Size = new System.Drawing.Size(243, 26);
            this.label_guess_range_title.TabIndex = 0;
            this.label_guess_range_title.Text = "Please input a number.";
            // 
            // button_guess_range_enter
            // 
            this.button_guess_range_enter.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_guess_range_enter.Location = new System.Drawing.Point(272, 12);
            this.button_guess_range_enter.Name = "button_guess_range_enter";
            this.button_guess_range_enter.Size = new System.Drawing.Size(90, 39);
            this.button_guess_range_enter.TabIndex = 1;
            this.button_guess_range_enter.Text = "Enter";
            this.button_guess_range_enter.UseVisualStyleBackColor = true;
            this.button_guess_range_enter.Click += new System.EventHandler(this.button_guess_range_enter_Click);
            // 
            // button_guess_range_cancel
            // 
            this.button_guess_range_cancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_guess_range_cancel.Location = new System.Drawing.Point(272, 51);
            this.button_guess_range_cancel.Name = "button_guess_range_cancel";
            this.button_guess_range_cancel.Size = new System.Drawing.Size(90, 37);
            this.button_guess_range_cancel.TabIndex = 2;
            this.button_guess_range_cancel.Text = "Cancel";
            this.button_guess_range_cancel.UseVisualStyleBackColor = true;
            this.button_guess_range_cancel.Click += new System.EventHandler(this.button_guess_range_cancel_Click);
            // 
            // textbox_guess_range_number
            // 
            this.textbox_guess_range_number.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_guess_range_number.Location = new System.Drawing.Point(17, 94);
            this.textbox_guess_range_number.Name = "textbox_guess_range_number";
            this.textbox_guess_range_number.Size = new System.Drawing.Size(345, 35);
            this.textbox_guess_range_number.TabIndex = 3;
            this.textbox_guess_range_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_guess_range
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.textbox_guess_range_number);
            this.Controls.Add(this.button_guess_range_cancel);
            this.Controls.Add(this.button_guess_range_enter);
            this.Controls.Add(this.label_guess_range_title);
            this.Name = "Form_guess_range";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_guess_range_title;
        private System.Windows.Forms.Button button_guess_range_enter;
        private System.Windows.Forms.Button button_guess_range_cancel;
        private System.Windows.Forms.TextBox textbox_guess_range_number;
    }
}