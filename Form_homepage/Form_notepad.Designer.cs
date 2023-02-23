namespace Form_homepage
{
    partial class Form_notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notepad));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_save_another = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_print = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_print_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_cancel_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_allselect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_tool = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_selfset = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_format_font_upper = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_font_color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_font_type = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_font_upper = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_font_lower = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_auto_nextline = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_select_color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_color_red = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_color_green = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_color_blue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_black = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_information = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_content = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_index = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.textbox_notepad = new System.Windows.Forms.TextBox();
            this.label_display_time = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_information = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_file,
            this.toolStripDropDownButton_edit,
            this.toolStripDropDownButton_tool,
            this.toolStripDropDownButton_format_font_upper,
            this.toolStripDropDownButton_information});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton_file
            // 
            this.toolStripDropDownButton_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_new,
            this.ToolStripMenuItem_open,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_save,
            this.ToolStripMenuItem_save_another,
            this.ToolStripMenuItem_print,
            this.ToolStripMenuItem_print_preview,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_exit});
            this.toolStripDropDownButton_file.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_file.Image")));
            this.toolStripDropDownButton_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_file.Name = "toolStripDropDownButton_file";
            this.toolStripDropDownButton_file.Size = new System.Drawing.Size(58, 22);
            this.toolStripDropDownButton_file.Text = "檔案(F)";
            // 
            // ToolStripMenuItem_new
            // 
            this.ToolStripMenuItem_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStripMenuItem_new.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_new.Image")));
            this.ToolStripMenuItem_new.Name = "ToolStripMenuItem_new";
            this.ToolStripMenuItem_new.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_new.Text = "新增(Ｎ)    Ctrl+N";
            this.ToolStripMenuItem_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripMenuItem_new.Click += new System.EventHandler(this.ToolStripMenuItem_new_Click);
            // 
            // ToolStripMenuItem_open
            // 
            this.ToolStripMenuItem_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStripMenuItem_open.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_open.Image")));
            this.ToolStripMenuItem_open.Name = "ToolStripMenuItem_open";
            this.ToolStripMenuItem_open.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_open.Text = "開啟(O)     Ctrl+O";
            this.ToolStripMenuItem_open.Click += new System.EventHandler(this.ToolStripMenuItem_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem_save
            // 
            this.ToolStripMenuItem_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStripMenuItem_save.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_save.Image")));
            this.ToolStripMenuItem_save.Name = "ToolStripMenuItem_save";
            this.ToolStripMenuItem_save.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_save.Text = "儲存(S)      Ctrl+S";
            this.ToolStripMenuItem_save.Click += new System.EventHandler(this.ToolStripMenuItem_save_Click);
            // 
            // ToolStripMenuItem_save_another
            // 
            this.ToolStripMenuItem_save_another.Name = "ToolStripMenuItem_save_another";
            this.ToolStripMenuItem_save_another.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_save_another.Text = "另存新檔";
            this.ToolStripMenuItem_save_another.Click += new System.EventHandler(this.ToolStripMenuItem_save_another_Click);
            // 
            // ToolStripMenuItem_print
            // 
            this.ToolStripMenuItem_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStripMenuItem_print.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_print.Image")));
            this.ToolStripMenuItem_print.Name = "ToolStripMenuItem_print";
            this.ToolStripMenuItem_print.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_print.Text = "列印(P)      Ctrl+P";
            // 
            // ToolStripMenuItem_print_preview
            // 
            this.ToolStripMenuItem_print_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStripMenuItem_print_preview.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_print_preview.Image")));
            this.ToolStripMenuItem_print_preview.Name = "ToolStripMenuItem_print_preview";
            this.ToolStripMenuItem_print_preview.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_print_preview.Text = "預覽列印(V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_exit.Text = "結束(X)";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // toolStripDropDownButton_edit
            // 
            this.toolStripDropDownButton_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_restore,
            this.ToolStripMenuItem_cancel_restore,
            this.toolStripSeparator5,
            this.ToolStripMenuItem_cut,
            this.ToolStripMenuItem_copy,
            this.ToolStripMenuItem_paste,
            this.ToolStripMenuItem_allselect});
            this.toolStripDropDownButton_edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_edit.Image")));
            this.toolStripDropDownButton_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_edit.Name = "toolStripDropDownButton_edit";
            this.toolStripDropDownButton_edit.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton_edit.Text = "編輯(E)";
            // 
            // ToolStripMenuItem_restore
            // 
            this.ToolStripMenuItem_restore.Name = "ToolStripMenuItem_restore";
            this.ToolStripMenuItem_restore.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_restore.Text = "復原(U)             Ctrl+Z";
            // 
            // ToolStripMenuItem_cancel_restore
            // 
            this.ToolStripMenuItem_cancel_restore.Name = "ToolStripMenuItem_cancel_restore";
            this.ToolStripMenuItem_cancel_restore.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_cancel_restore.Text = "取消復原(R)     Ctrl+Y";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // ToolStripMenuItem_cut
            // 
            this.ToolStripMenuItem_cut.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_cut.Image")));
            this.ToolStripMenuItem_cut.Name = "ToolStripMenuItem_cut";
            this.ToolStripMenuItem_cut.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_cut.Text = "剪下(T)             Ctrl+X    ";
            this.ToolStripMenuItem_cut.Click += new System.EventHandler(this.ToolStripMenuItem_cut_Click);
            // 
            // ToolStripMenuItem_copy
            // 
            this.ToolStripMenuItem_copy.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_copy.Image")));
            this.ToolStripMenuItem_copy.Name = "ToolStripMenuItem_copy";
            this.ToolStripMenuItem_copy.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_copy.Text = "複製(C)             Ctrl+C";
            this.ToolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItem_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_paste.Image")));
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_paste.Text = "貼上(P)             Ctrl+V";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItem_paste_Click);
            // 
            // ToolStripMenuItem_allselect
            // 
            this.ToolStripMenuItem_allselect.Name = "ToolStripMenuItem_allselect";
            this.ToolStripMenuItem_allselect.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem_allselect.Text = "全選(A)";
            this.ToolStripMenuItem_allselect.Click += new System.EventHandler(this.ToolStripMenuItem_allselect_Click);
            // 
            // toolStripDropDownButton_tool
            // 
            this.toolStripDropDownButton_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_selfset,
            this.ToolStripMenuItem_option});
            this.toolStripDropDownButton_tool.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_tool.Image")));
            this.toolStripDropDownButton_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_tool.Name = "toolStripDropDownButton_tool";
            this.toolStripDropDownButton_tool.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton_tool.Text = "工具(T)";
            // 
            // ToolStripMenuItem_selfset
            // 
            this.ToolStripMenuItem_selfset.Name = "ToolStripMenuItem_selfset";
            this.ToolStripMenuItem_selfset.Size = new System.Drawing.Size(116, 22);
            this.ToolStripMenuItem_selfset.Text = "自訂(C)";
            // 
            // ToolStripMenuItem_option
            // 
            this.ToolStripMenuItem_option.Name = "ToolStripMenuItem_option";
            this.ToolStripMenuItem_option.Size = new System.Drawing.Size(116, 22);
            this.ToolStripMenuItem_option.Text = "選項(O)";
            // 
            // toolStripDropDownButton_format_font_upper
            // 
            this.toolStripDropDownButton_format_font_upper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_format_font_upper.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_font_color,
            this.ToolStripMenuItem_font_type,
            this.ToolStripMenuItem_font_upper,
            this.ToolStripMenuItem_font_lower,
            this.ToolStripMenuItem_auto_nextline,
            this.ToolStripMenuItem_select_color});
            this.toolStripDropDownButton_format_font_upper.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_format_font_upper.Image")));
            this.toolStripDropDownButton_format_font_upper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_format_font_upper.Name = "toolStripDropDownButton_format_font_upper";
            this.toolStripDropDownButton_format_font_upper.Size = new System.Drawing.Size(64, 22);
            this.toolStripDropDownButton_format_font_upper.Text = "格式(M)";
            // 
            // ToolStripMenuItem_font_color
            // 
            this.ToolStripMenuItem_font_color.Name = "ToolStripMenuItem_font_color";
            this.ToolStripMenuItem_font_color.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_font_color.Text = "顏色(C)...";
            this.ToolStripMenuItem_font_color.Click += new System.EventHandler(this.ToolStripMenuItem_font_color_Click);
            // 
            // ToolStripMenuItem_font_type
            // 
            this.ToolStripMenuItem_font_type.Name = "ToolStripMenuItem_font_type";
            this.ToolStripMenuItem_font_type.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_font_type.Text = "字型(V)...";
            this.ToolStripMenuItem_font_type.Click += new System.EventHandler(this.ToolStripMenuItem_font_type_Click);
            // 
            // ToolStripMenuItem_font_upper
            // 
            this.ToolStripMenuItem_font_upper.Name = "ToolStripMenuItem_font_upper";
            this.ToolStripMenuItem_font_upper.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_font_upper.Text = "To Upper(U)";
            this.ToolStripMenuItem_font_upper.Click += new System.EventHandler(this.ToolStripMenuItem_font_upper_Click);
            // 
            // ToolStripMenuItem_font_lower
            // 
            this.ToolStripMenuItem_font_lower.Name = "ToolStripMenuItem_font_lower";
            this.ToolStripMenuItem_font_lower.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_font_lower.Text = "To Lower(L)";
            this.ToolStripMenuItem_font_lower.Click += new System.EventHandler(this.ToolStripMenuItem_font_lower_Click);
            // 
            // ToolStripMenuItem_auto_nextline
            // 
            this.ToolStripMenuItem_auto_nextline.Name = "ToolStripMenuItem_auto_nextline";
            this.ToolStripMenuItem_auto_nextline.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_auto_nextline.Text = "自動換行";
            // 
            // ToolStripMenuItem_select_color
            // 
            this.ToolStripMenuItem_select_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_color_red,
            this.ToolStripMenuItem_color_green,
            this.ToolStripMenuItem_color_blue,
            this.ToolStripMenuItem_black});
            this.ToolStripMenuItem_select_color.Name = "ToolStripMenuItem_select_color";
            this.ToolStripMenuItem_select_color.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_select_color.Text = "快選顏色";
            // 
            // ToolStripMenuItem_color_red
            // 
            this.ToolStripMenuItem_color_red.Name = "ToolStripMenuItem_color_red";
            this.ToolStripMenuItem_color_red.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItem_color_red.Text = "Red";
            this.ToolStripMenuItem_color_red.Click += new System.EventHandler(this.ToolStripMenuItem_color_red_Click);
            // 
            // ToolStripMenuItem_color_green
            // 
            this.ToolStripMenuItem_color_green.Name = "ToolStripMenuItem_color_green";
            this.ToolStripMenuItem_color_green.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItem_color_green.Text = "Green";
            this.ToolStripMenuItem_color_green.Click += new System.EventHandler(this.ToolStripMenuItem_color_green_Click);
            // 
            // ToolStripMenuItem_color_blue
            // 
            this.ToolStripMenuItem_color_blue.Name = "ToolStripMenuItem_color_blue";
            this.ToolStripMenuItem_color_blue.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItem_color_blue.Text = "Blue";
            this.ToolStripMenuItem_color_blue.Click += new System.EventHandler(this.ToolStripMenuItem_color_blue_Click);
            // 
            // ToolStripMenuItem_black
            // 
            this.ToolStripMenuItem_black.Name = "ToolStripMenuItem_black";
            this.ToolStripMenuItem_black.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItem_black.Text = "Black";
            this.ToolStripMenuItem_black.Click += new System.EventHandler(this.ToolStripMenuItem_black_Click);
            // 
            // toolStripDropDownButton_information
            // 
            this.toolStripDropDownButton_information.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_content,
            this.ToolStripMenuItem_index,
            this.ToolStripMenuItem_search,
            this.ToolStripMenuItem_about});
            this.toolStripDropDownButton_information.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_information.Image")));
            this.toolStripDropDownButton_information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_information.Name = "toolStripDropDownButton_information";
            this.toolStripDropDownButton_information.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton_information.Text = "說明(H)";
            // 
            // ToolStripMenuItem_content
            // 
            this.ToolStripMenuItem_content.Name = "ToolStripMenuItem_content";
            this.ToolStripMenuItem_content.Size = new System.Drawing.Size(123, 22);
            this.ToolStripMenuItem_content.Text = "內容(C)";
            // 
            // ToolStripMenuItem_index
            // 
            this.ToolStripMenuItem_index.Name = "ToolStripMenuItem_index";
            this.ToolStripMenuItem_index.Size = new System.Drawing.Size(123, 22);
            this.ToolStripMenuItem_index.Text = "索引(I)";
            // 
            // ToolStripMenuItem_search
            // 
            this.ToolStripMenuItem_search.Name = "ToolStripMenuItem_search";
            this.ToolStripMenuItem_search.Size = new System.Drawing.Size(123, 22);
            this.ToolStripMenuItem_search.Text = "搜尋(S)";
            // 
            // ToolStripMenuItem_about
            // 
            this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
            this.ToolStripMenuItem_about.Size = new System.Drawing.Size(123, 22);
            this.ToolStripMenuItem_about.Text = "關於(A)...";
            this.ToolStripMenuItem_about.Click += new System.EventHandler(this.ToolStripMenuItem_about_Click);
            // 
            // textbox_notepad
            // 
            this.textbox_notepad.Location = new System.Drawing.Point(3, 3);
            this.textbox_notepad.Multiline = true;
            this.textbox_notepad.Name = "textbox_notepad";
            this.textbox_notepad.Size = new System.Drawing.Size(803, 22);
            this.textbox_notepad.TabIndex = 0;
            // 
            // label_display_time
            // 
            this.label_display_time.AutoSize = true;
            this.label_display_time.Location = new System.Drawing.Point(3, 374);
            this.label_display_time.Name = "label_display_time";
            this.label_display_time.Size = new System.Drawing.Size(33, 12);
            this.label_display_time.TabIndex = 1;
            this.label_display_time.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_display_time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textbox_notepad, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.83887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.161125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_new,
            this.toolStripButton_open,
            this.toolStripButton_save,
            this.toolStripButton_print,
            this.toolStripSeparator3,
            this.toolStripButton_cut,
            this.toolStripButton_copy,
            this.toolStripButton_paste,
            this.toolStripSeparator4,
            this.toolStripButton_information});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_new
            // 
            this.toolStripButton_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_new.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_new.Image")));
            this.toolStripButton_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_new.Name = "toolStripButton_new";
            this.toolStripButton_new.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_new.Text = "toolStripButton1";
            this.toolStripButton_new.ToolTipText = "新增(N)";
            // 
            // toolStripButton_open
            // 
            this.toolStripButton_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_open.Image")));
            this.toolStripButton_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_open.Name = "toolStripButton_open";
            this.toolStripButton_open.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_open.Text = "toolStripButton2";
            this.toolStripButton_open.ToolTipText = "開啟(O)";
            this.toolStripButton_open.Click += new System.EventHandler(this.toolStripButton_open_Click);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_save.Text = "toolStripButton3";
            this.toolStripButton_save.ToolTipText = "儲存(S)";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // toolStripButton_print
            // 
            this.toolStripButton_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_print.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_print.Image")));
            this.toolStripButton_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_print.Name = "toolStripButton_print";
            this.toolStripButton_print.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_print.Text = "toolStripButton4";
            this.toolStripButton_print.ToolTipText = "列印(P)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_cut
            // 
            this.toolStripButton_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_cut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_cut.Image")));
            this.toolStripButton_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_cut.Name = "toolStripButton_cut";
            this.toolStripButton_cut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_cut.Text = "toolStripButton5";
            this.toolStripButton_cut.ToolTipText = "剪下(U)";
            this.toolStripButton_cut.Click += new System.EventHandler(this.toolStripButton_cut_Click);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_copy.Image")));
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_copy.Text = "toolStripButton6";
            this.toolStripButton_copy.ToolTipText = "複製(C)";
            this.toolStripButton_copy.Click += new System.EventHandler(this.toolStripButton_copy_Click);
            // 
            // toolStripButton_paste
            // 
            this.toolStripButton_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_paste.Image")));
            this.toolStripButton_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_paste.Name = "toolStripButton_paste";
            this.toolStripButton_paste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_paste.Text = "toolStripButton7";
            this.toolStripButton_paste.ToolTipText = "貼上(P)";
            this.toolStripButton_paste.Click += new System.EventHandler(this.toolStripButton_paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_information
            // 
            this.toolStripButton_information.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_information.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_information.Image")));
            this.toolStripButton_information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_information.Name = "toolStripButton_information";
            this.toolStripButton_information.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_information.Text = "toolStripButton8";
            this.toolStripButton_information.ToolTipText = "說明(L)";
            this.toolStripButton_information.Click += new System.EventHandler(this.toolStripButton_information_Click);
            // 
            // Form_notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_notepad";
            this.Text = "Form_notepad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textbox_notepad;
        private System.Windows.Forms.Label label_display_time;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_file;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_new;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_save_another;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_print;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_print_preview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_edit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_tool;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_format_font_upper;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_information;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_new;
        private System.Windows.Forms.ToolStripButton toolStripButton_open;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripButton toolStripButton_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_cut;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton_information;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_font_color;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_font_type;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_font_upper;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_font_lower;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_auto_nextline;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_select_color;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_color_red;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_color_green;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_color_blue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_black;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_restore;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cancel_restore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_allselect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_content;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_index;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_search;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_selfset;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option;
    }
}