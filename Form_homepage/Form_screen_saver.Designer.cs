namespace Form_homepage
{
    partial class Form_screen_saver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_screen_saver));
            this.picturebox_screen_saver = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_screen_saver)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_screen_saver
            // 
            this.picturebox_screen_saver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_screen_saver.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_screen_saver.Image")));
            this.picturebox_screen_saver.Location = new System.Drawing.Point(58, 25);
            this.picturebox_screen_saver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturebox_screen_saver.Name = "picturebox_screen_saver";
            this.picturebox_screen_saver.Size = new System.Drawing.Size(269, 221);
            this.picturebox_screen_saver.TabIndex = 0;
            this.picturebox_screen_saver.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // Form_screen_saver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.picturebox_screen_saver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_screen_saver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_screen_saver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_screen_saver_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_screen_saver_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_screen_saver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_screen_saver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_screen_saver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_screen_saver;
        private System.Windows.Forms.Timer moveTimer;
    }
}