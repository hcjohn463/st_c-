namespace Form_homepage
{
    partial class Form_for_do_while
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
            this.label_rows = new System.Windows.Forms.Label();
            this.textbox_rows = new System.Windows.Forms.TextBox();
            this.button_tree = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_result_title = new System.Windows.Forms.Label();
            this.button_99 = new System.Windows.Forms.Button();
            this.button_100binary = new System.Windows.Forms.Button();
            this.button_lotto = new System.Windows.Forms.Button();
            this.textbox_from = new System.Windows.Forms.TextBox();
            this.textbox_to = new System.Windows.Forms.TextBox();
            this.label_from = new System.Windows.Forms.Label();
            this.lable_to = new System.Windows.Forms.Label();
            this.label_step = new System.Windows.Forms.Label();
            this.textbox_step = new System.Windows.Forms.TextBox();
            this.button_for = new System.Windows.Forms.Button();
            this.button_while = new System.Windows.Forms.Button();
            this.button_do = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_rows
            // 
            this.label_rows.AutoSize = true;
            this.label_rows.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_rows.Location = new System.Drawing.Point(12, 27);
            this.label_rows.Name = "label_rows";
            this.label_rows.Size = new System.Drawing.Size(50, 19);
            this.label_rows.TabIndex = 0;
            this.label_rows.Text = "Rows:";
            // 
            // textbox_rows
            // 
            this.textbox_rows.Location = new System.Drawing.Point(69, 27);
            this.textbox_rows.Name = "textbox_rows";
            this.textbox_rows.Size = new System.Drawing.Size(51, 22);
            this.textbox_rows.TabIndex = 1;
            // 
            // button_tree
            // 
            this.button_tree.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_tree.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_tree.Location = new System.Drawing.Point(135, 16);
            this.button_tree.Name = "button_tree";
            this.button_tree.Size = new System.Drawing.Size(85, 33);
            this.button_tree.TabIndex = 2;
            this.button_tree.Text = "直角聖誕樹";
            this.button_tree.UseVisualStyleBackColor = false;
            this.button_tree.Click += new System.EventHandler(this.button_tree_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.BackColor = System.Drawing.Color.PapayaWhip;
            this.label_result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result.Location = new System.Drawing.Point(12, 92);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(41, 20);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "結果";
            // 
            // label_result_title
            // 
            this.label_result_title.AutoSize = true;
            this.label_result_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_result_title.Location = new System.Drawing.Point(11, 62);
            this.label_result_title.Name = "label_result_title";
            this.label_result_title.Size = new System.Drawing.Size(70, 24);
            this.label_result_title.TabIndex = 6;
            this.label_result_title.Text = "Result:";
            // 
            // button_99
            // 
            this.button_99.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_99.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_99.Location = new System.Drawing.Point(226, 14);
            this.button_99.Name = "button_99";
            this.button_99.Size = new System.Drawing.Size(84, 36);
            this.button_99.TabIndex = 7;
            this.button_99.Text = "九九乘法表";
            this.button_99.UseVisualStyleBackColor = false;
            this.button_99.Click += new System.EventHandler(this.button_99_Click);
            // 
            // button_100binary
            // 
            this.button_100binary.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_100binary.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_100binary.Location = new System.Drawing.Point(316, 13);
            this.button_100binary.Name = "button_100binary";
            this.button_100binary.Size = new System.Drawing.Size(112, 36);
            this.button_100binary.TabIndex = 8;
            this.button_100binary.Text = "100的二進位是?";
            this.button_100binary.UseVisualStyleBackColor = false;
            this.button_100binary.Click += new System.EventHandler(this.button_100binary_Click);
            // 
            // button_lotto
            // 
            this.button_lotto.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_lotto.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_lotto.Location = new System.Drawing.Point(434, 13);
            this.button_lotto.Name = "button_lotto";
            this.button_lotto.Size = new System.Drawing.Size(110, 36);
            this.button_lotto.TabIndex = 9;
            this.button_lotto.Text = "樂透號碼不重複";
            this.button_lotto.UseVisualStyleBackColor = false;
            this.button_lotto.Click += new System.EventHandler(this.button_lotto_Click);
            // 
            // textbox_from
            // 
            this.textbox_from.Location = new System.Drawing.Point(599, 5);
            this.textbox_from.Name = "textbox_from";
            this.textbox_from.Size = new System.Drawing.Size(51, 22);
            this.textbox_from.TabIndex = 10;
            // 
            // textbox_to
            // 
            this.textbox_to.Location = new System.Drawing.Point(599, 30);
            this.textbox_to.Name = "textbox_to";
            this.textbox_to.Size = new System.Drawing.Size(51, 22);
            this.textbox_to.TabIndex = 11;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_from.Location = new System.Drawing.Point(550, 13);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(49, 19);
            this.label_from.TabIndex = 13;
            this.label_from.Text = "From:";
            this.label_from.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lable_to
            // 
            this.lable_to.AutoSize = true;
            this.lable_to.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable_to.Location = new System.Drawing.Point(570, 36);
            this.lable_to.Name = "lable_to";
            this.lable_to.Size = new System.Drawing.Size(29, 19);
            this.lable_to.TabIndex = 14;
            this.lable_to.Text = "To:";
            this.lable_to.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_step.Location = new System.Drawing.Point(556, 55);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(43, 19);
            this.label_step.TabIndex = 15;
            this.label_step.Text = "Step:";
            this.label_step.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textbox_step
            // 
            this.textbox_step.Location = new System.Drawing.Point(599, 55);
            this.textbox_step.Name = "textbox_step";
            this.textbox_step.Size = new System.Drawing.Size(51, 22);
            this.textbox_step.TabIndex = 16;
            // 
            // button_for
            // 
            this.button_for.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_for.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_for.Location = new System.Drawing.Point(656, 5);
            this.button_for.Name = "button_for";
            this.button_for.Size = new System.Drawing.Size(47, 27);
            this.button_for.TabIndex = 17;
            this.button_for.Text = "for";
            this.button_for.UseVisualStyleBackColor = false;
            this.button_for.Click += new System.EventHandler(this.button_for_Click);
            // 
            // button_while
            // 
            this.button_while.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_while.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_while.Location = new System.Drawing.Point(656, 33);
            this.button_while.Name = "button_while";
            this.button_while.Size = new System.Drawing.Size(47, 27);
            this.button_while.TabIndex = 18;
            this.button_while.Text = "while";
            this.button_while.UseVisualStyleBackColor = false;
            this.button_while.Click += new System.EventHandler(this.button_while_Click);
            // 
            // button_do
            // 
            this.button_do.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_do.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_do.Location = new System.Drawing.Point(656, 62);
            this.button_do.Name = "button_do";
            this.button_do.Size = new System.Drawing.Size(47, 27);
            this.button_do.TabIndex = 19;
            this.button_do.Text = "do";
            this.button_do.UseVisualStyleBackColor = false;
            this.button_do.Click += new System.EventHandler(this.button_do_Click);
            // 
            // Form_for_do_while
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_do);
            this.Controls.Add(this.button_while);
            this.Controls.Add(this.button_for);
            this.Controls.Add(this.textbox_step);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.lable_to);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.textbox_to);
            this.Controls.Add(this.textbox_from);
            this.Controls.Add(this.button_lotto);
            this.Controls.Add(this.button_100binary);
            this.Controls.Add(this.button_99);
            this.Controls.Add(this.label_result_title);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_tree);
            this.Controls.Add(this.textbox_rows);
            this.Controls.Add(this.label_rows);
            this.Name = "Form_for_do_while";
            this.Text = "Form_for_do_while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rows;
        private System.Windows.Forms.TextBox textbox_rows;
        private System.Windows.Forms.Button button_tree;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_result_title;
        private System.Windows.Forms.Button button_99;
        private System.Windows.Forms.Button button_100binary;
        private System.Windows.Forms.Button button_lotto;
        private System.Windows.Forms.TextBox textbox_from;
        private System.Windows.Forms.TextBox textbox_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label lable_to;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.TextBox textbox_step;
        private System.Windows.Forms.Button button_for;
        private System.Windows.Forms.Button button_while;
        private System.Windows.Forms.Button button_do;
    }
}