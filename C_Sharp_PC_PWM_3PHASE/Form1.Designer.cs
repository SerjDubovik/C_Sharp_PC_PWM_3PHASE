namespace C_Sharp_PC_PWM_3PHASE
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main_menu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Property = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_transport_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_for_Displ = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_count_connect = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Main_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Property,
            this.ToolStripMenuItem_Help});
            this.Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(820, 24);
            this.Main_menu.TabIndex = 6;
            this.Main_menu.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(109, 22);
            this.ToolStripMenuItem_exit.Text = "Выход";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // ToolStripMenuItem_Property
            // 
            this.ToolStripMenuItem_Property.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_transport_btn});
            this.ToolStripMenuItem_Property.Name = "ToolStripMenuItem_Property";
            this.ToolStripMenuItem_Property.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItem_Property.Text = "Настройки";
            // 
            // ToolStripMenuItem_transport_btn
            // 
            this.ToolStripMenuItem_transport_btn.Name = "ToolStripMenuItem_transport_btn";
            this.ToolStripMenuItem_transport_btn.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_transport_btn.Text = "Передача данных";
            this.ToolStripMenuItem_transport_btn.Click += new System.EventHandler(this.ToolStripMenuItem_transport_btn_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_help_btn,
            this.ToolStripMenuItem_about});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItem_Help.Text = "Помощь";
            // 
            // ToolStripMenuItem_help_btn
            // 
            this.ToolStripMenuItem_help_btn.Name = "ToolStripMenuItem_help_btn";
            this.ToolStripMenuItem_help_btn.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_help_btn.Text = "Справка";
            // 
            // ToolStripMenuItem_about
            // 
            this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
            this.ToolStripMenuItem_about.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_about.Text = "О программе";
            // 
            // timer_for_Displ
            // 
            this.timer_for_Displ.Enabled = true;
            this.timer_for_Displ.Interval = 300;
            this.timer_for_Displ.Tick += new System.EventHandler(this.timer_for_Displ_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "    ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel3.Text = "    ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel4.Text = "    ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "    ";
            // 
            // label_count_connect
            // 
            this.label_count_connect.Location = new System.Drawing.Point(112, 534);
            this.label_count_connect.Name = "label_count_connect";
            this.label_count_connect.Size = new System.Drawing.Size(63, 16);
            this.label_count_connect.TabIndex = 26;
            this.label_count_connect.Text = "NuN";
            this.label_count_connect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Проверка связи:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.label_count_connect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Main_menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Property;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_transport_btn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help_btn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
        private System.Windows.Forms.Timer timer_for_Displ;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.Label label_count_connect;
        private System.Windows.Forms.Label label9;
    }
}

