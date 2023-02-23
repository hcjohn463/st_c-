namespace Form_homepage
{
    partial class Form_loan
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
            this.label_loan_amount = new System.Windows.Forms.Label();
            this.label_loan_year = new System.Windows.Forms.Label();
            this.label_loan_rate = new System.Windows.Forms.Label();
            this.label_loan_downpayment = new System.Windows.Forms.Label();
            this.textbox_loan_amount = new System.Windows.Forms.TextBox();
            this.textbox_loan_year = new System.Windows.Forms.TextBox();
            this.textbox_loan_rate = new System.Windows.Forms.TextBox();
            this.textbox_loan_downpayment = new System.Windows.Forms.TextBox();
            this.button_loan_pmt = new System.Windows.Forms.Button();
            this.button_loan_total = new System.Windows.Forms.Button();
            this.button_loan_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_loan_amount
            // 
            this.label_loan_amount.AutoSize = true;
            this.label_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_amount.Location = new System.Drawing.Point(108, 40);
            this.label_loan_amount.Name = "label_loan_amount";
            this.label_loan_amount.Size = new System.Drawing.Size(123, 35);
            this.label_loan_amount.TabIndex = 0;
            this.label_loan_amount.Text = "貸款金額";
            // 
            // label_loan_year
            // 
            this.label_loan_year.AutoSize = true;
            this.label_loan_year.CausesValidation = false;
            this.label_loan_year.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_year.Location = new System.Drawing.Point(108, 108);
            this.label_loan_year.Name = "label_loan_year";
            this.label_loan_year.Size = new System.Drawing.Size(114, 35);
            this.label_loan_year.TabIndex = 1;
            this.label_loan_year.Text = "期限(年)";
            // 
            // label_loan_rate
            // 
            this.label_loan_rate.AutoSize = true;
            this.label_loan_rate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_rate.Location = new System.Drawing.Point(111, 169);
            this.label_loan_rate.Name = "label_loan_rate";
            this.label_loan_rate.Size = new System.Drawing.Size(111, 35);
            this.label_loan_rate.TabIndex = 2;
            this.label_loan_rate.Text = "利率(%)";
            // 
            // label_loan_downpayment
            // 
            this.label_loan_downpayment.AutoSize = true;
            this.label_loan_downpayment.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_downpayment.Location = new System.Drawing.Point(111, 234);
            this.label_loan_downpayment.Name = "label_loan_downpayment";
            this.label_loan_downpayment.Size = new System.Drawing.Size(96, 35);
            this.label_loan_downpayment.TabIndex = 3;
            this.label_loan_downpayment.Text = "頭期款";
            // 
            // textbox_loan_amount
            // 
            this.textbox_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_amount.Location = new System.Drawing.Point(259, 43);
            this.textbox_loan_amount.Name = "textbox_loan_amount";
            this.textbox_loan_amount.Size = new System.Drawing.Size(155, 35);
            this.textbox_loan_amount.TabIndex = 4;
            this.textbox_loan_amount.Text = "100000";
            // 
            // textbox_loan_year
            // 
            this.textbox_loan_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_year.Location = new System.Drawing.Point(259, 108);
            this.textbox_loan_year.Name = "textbox_loan_year";
            this.textbox_loan_year.Size = new System.Drawing.Size(155, 35);
            this.textbox_loan_year.TabIndex = 5;
            this.textbox_loan_year.Text = "2";
            // 
            // textbox_loan_rate
            // 
            this.textbox_loan_rate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_rate.Location = new System.Drawing.Point(259, 172);
            this.textbox_loan_rate.Name = "textbox_loan_rate";
            this.textbox_loan_rate.Size = new System.Drawing.Size(155, 35);
            this.textbox_loan_rate.TabIndex = 6;
            this.textbox_loan_rate.Text = "10";
            // 
            // textbox_loan_downpayment
            // 
            this.textbox_loan_downpayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_downpayment.Location = new System.Drawing.Point(259, 237);
            this.textbox_loan_downpayment.Name = "textbox_loan_downpayment";
            this.textbox_loan_downpayment.Size = new System.Drawing.Size(155, 35);
            this.textbox_loan_downpayment.TabIndex = 7;
            this.textbox_loan_downpayment.Text = "0";
            // 
            // button_loan_pmt
            // 
            this.button_loan_pmt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_loan_pmt.Location = new System.Drawing.Point(114, 315);
            this.button_loan_pmt.Name = "button_loan_pmt";
            this.button_loan_pmt.Size = new System.Drawing.Size(145, 59);
            this.button_loan_pmt.TabIndex = 8;
            this.button_loan_pmt.Text = "PMT(月付)";
            this.button_loan_pmt.UseVisualStyleBackColor = true;
            this.button_loan_pmt.Click += new System.EventHandler(this.button_loan_pmt_Click);
            // 
            // button_loan_total
            // 
            this.button_loan_total.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_loan_total.Location = new System.Drawing.Point(297, 315);
            this.button_loan_total.Name = "button_loan_total";
            this.button_loan_total.Size = new System.Drawing.Size(137, 59);
            this.button_loan_total.TabIndex = 9;
            this.button_loan_total.Text = "總付款";
            this.button_loan_total.UseVisualStyleBackColor = true;
            this.button_loan_total.Click += new System.EventHandler(this.button_loan_total_Click);
            // 
            // button_loan_report
            // 
            this.button_loan_report.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_loan_report.Location = new System.Drawing.Point(489, 315);
            this.button_loan_report.Name = "button_loan_report";
            this.button_loan_report.Size = new System.Drawing.Size(137, 59);
            this.button_loan_report.TabIndex = 10;
            this.button_loan_report.Text = "Report";
            this.button_loan_report.UseVisualStyleBackColor = true;
            this.button_loan_report.Click += new System.EventHandler(this.button_loan_report_Click);
            // 
            // Form_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_loan_report);
            this.Controls.Add(this.button_loan_total);
            this.Controls.Add(this.button_loan_pmt);
            this.Controls.Add(this.textbox_loan_downpayment);
            this.Controls.Add(this.textbox_loan_rate);
            this.Controls.Add(this.textbox_loan_year);
            this.Controls.Add(this.textbox_loan_amount);
            this.Controls.Add(this.label_loan_downpayment);
            this.Controls.Add(this.label_loan_rate);
            this.Controls.Add(this.label_loan_year);
            this.Controls.Add(this.label_loan_amount);
            this.Name = "Form_loan";
            this.Text = "貸款金額試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loan_amount;
        private System.Windows.Forms.Label label_loan_year;
        private System.Windows.Forms.Label label_loan_rate;
        private System.Windows.Forms.Label label_loan_downpayment;
        private System.Windows.Forms.TextBox textbox_loan_amount;
        private System.Windows.Forms.TextBox textbox_loan_year;
        private System.Windows.Forms.TextBox textbox_loan_rate;
        private System.Windows.Forms.TextBox textbox_loan_downpayment;
        private System.Windows.Forms.Button button_loan_pmt;
        private System.Windows.Forms.Button button_loan_total;
        private System.Windows.Forms.Button button_loan_report;
    }
}