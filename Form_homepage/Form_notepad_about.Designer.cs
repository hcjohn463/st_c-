namespace Form_homepage
{
    partial class Form_notepad_about
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
            this.label_notepad_about_title = new System.Windows.Forms.Label();
            this.label_notepad_about_content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_notepad_about_title
            // 
            this.label_notepad_about_title.AutoSize = true;
            this.label_notepad_about_title.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_notepad_about_title.Location = new System.Drawing.Point(12, 20);
            this.label_notepad_about_title.Name = "label_notepad_about_title";
            this.label_notepad_about_title.Size = new System.Drawing.Size(75, 37);
            this.label_notepad_about_title.TabIndex = 0;
            this.label_notepad_about_title.Text = "關於";
            // 
            // label_notepad_about_content
            // 
            this.label_notepad_about_content.AutoSize = true;
            this.label_notepad_about_content.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_notepad_about_content.Location = new System.Drawing.Point(12, 69);
            this.label_notepad_about_content.Name = "label_notepad_about_content";
            this.label_notepad_about_content.Size = new System.Drawing.Size(335, 38);
            this.label_notepad_about_content.TabIndex = 1;
            this.label_notepad_about_content.Text = "此版本為張信中在資策會C#的筆記本作業1.0版，\r\n敬請您安心服用。";
            // 
            // Form_notepad_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 132);
            this.Controls.Add(this.label_notepad_about_content);
            this.Controls.Add(this.label_notepad_about_title);
            this.Name = "Form_notepad_about";
            this.Text = "關於";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_notepad_about_title;
        private System.Windows.Forms.Label label_notepad_about_content;
    }
}