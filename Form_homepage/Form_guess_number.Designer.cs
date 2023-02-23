namespace Form_homepage
{
    partial class Form_guess_number
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
            this.label_guess_number_title = new System.Windows.Forms.Label();
            this.button_geuss_number_guess = new System.Windows.Forms.Button();
            this.button_guess_number_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_guess_number_title
            // 
            this.label_guess_number_title.AutoSize = true;
            this.label_guess_number_title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_guess_number_title.Location = new System.Drawing.Point(167, 62);
            this.label_guess_number_title.Name = "label_guess_number_title";
            this.label_guess_number_title.Size = new System.Drawing.Size(444, 26);
            this.label_guess_number_title.TabIndex = 0;
            this.label_guess_number_title.Text = "Please Select A Number Between 1 to 100!";
            // 
            // button_geuss_number_guess
            // 
            this.button_geuss_number_guess.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_geuss_number_guess.Location = new System.Drawing.Point(192, 163);
            this.button_geuss_number_guess.Name = "button_geuss_number_guess";
            this.button_geuss_number_guess.Size = new System.Drawing.Size(149, 63);
            this.button_geuss_number_guess.TabIndex = 1;
            this.button_geuss_number_guess.Text = "Guess";
            this.button_geuss_number_guess.UseVisualStyleBackColor = true;
            this.button_geuss_number_guess.Click += new System.EventHandler(this.button_geuss_number_guess_Click);
            // 
            // button_guess_number_show
            // 
            this.button_guess_number_show.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_guess_number_show.Location = new System.Drawing.Point(387, 163);
            this.button_guess_number_show.Name = "button_guess_number_show";
            this.button_guess_number_show.Size = new System.Drawing.Size(203, 63);
            this.button_guess_number_show.TabIndex = 2;
            this.button_guess_number_show.Text = "Show Answer";
            this.button_guess_number_show.UseVisualStyleBackColor = true;
            this.button_guess_number_show.Click += new System.EventHandler(this.button_guess_number_show_Click);
            // 
            // Form_guess_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_guess_number_show);
            this.Controls.Add(this.button_geuss_number_guess);
            this.Controls.Add(this.label_guess_number_title);
            this.Name = "Form_guess_number";
            this.Text = "考試_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.Label label_guess_number_title;
        private System.Windows.Forms.Button button_geuss_number_guess;
        private System.Windows.Forms.Button button_guess_number_show;
    }
}