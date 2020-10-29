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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_U_zpt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_threshold_U_zpt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_state_rele = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.A0 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_telemetry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.M9 = new System.Windows.Forms.Label();
            this.M10 = new System.Windows.Forms.Label();
            this.M11 = new System.Windows.Forms.Label();
            this.M12 = new System.Windows.Forms.Label();
            this.Main_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.Main_menu.Size = new System.Drawing.Size(1125, 24);
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
            this.statusStrip1.Size = new System.Drawing.Size(1125, 22);
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
            this.label_count_connect.Location = new System.Drawing.Point(118, 533);
            this.label_count_connect.Name = "label_count_connect";
            this.label_count_connect.Size = new System.Drawing.Size(63, 16);
            this.label_count_connect.TabIndex = 26;
            this.label_count_connect.Text = "NuN";
            this.label_count_connect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Проверка связи:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(770, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 188);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление ШИМ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Напряжение ЗПТ:";
            // 
            // label_U_zpt
            // 
            this.label_U_zpt.AutoSize = true;
            this.label_U_zpt.Location = new System.Drawing.Point(191, 27);
            this.label_U_zpt.Name = "label_U_zpt";
            this.label_U_zpt.Size = new System.Drawing.Size(29, 13);
            this.label_U_zpt.TabIndex = 31;
            this.label_U_zpt.Text = "NuN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Порог срабатывания текущий:";
            // 
            // label_threshold_U_zpt
            // 
            this.label_threshold_U_zpt.AutoSize = true;
            this.label_threshold_U_zpt.Location = new System.Drawing.Point(191, 50);
            this.label_threshold_U_zpt.Name = "label_threshold_U_zpt";
            this.label_threshold_U_zpt.Size = new System.Drawing.Size(29, 13);
            this.label_threshold_U_zpt.TabIndex = 31;
            this.label_threshold_U_zpt.Text = "NuN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_state_rele);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label_threshold_U_zpt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_U_zpt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(488, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 188);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Звено постоянного тока";
            // 
            // label_state_rele
            // 
            this.label_state_rele.AutoSize = true;
            this.label_state_rele.BackColor = System.Drawing.Color.White;
            this.label_state_rele.Location = new System.Drawing.Point(19, 156);
            this.label_state_rele.Name = "label_state_rele";
            this.label_state_rele.Size = new System.Drawing.Size(95, 13);
            this.label_state_rele.TabIndex = 59;
            this.label_state_rele.Text = "Реле разомкнуто";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Задать порог срабатывания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "В";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 126);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(221, 17);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Принудительно замкнуть реле заряда";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Автономная работа";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // A0
            // 
            this.A0.AutoSize = true;
            this.A0.Location = new System.Drawing.Point(356, 422);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(29, 13);
            this.A0.TabIndex = 37;
            this.A0.Text = "NuN";
            // 
            // A4
            // 
            this.A4.AutoSize = true;
            this.A4.Location = new System.Drawing.Point(356, 445);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(29, 13);
            this.A4.TabIndex = 38;
            this.A4.Text = "NuN";
            // 
            // A5
            // 
            this.A5.AutoSize = true;
            this.A5.Location = new System.Drawing.Point(356, 470);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(29, 13);
            this.A5.TabIndex = 39;
            this.A5.Text = "NuN";
            // 
            // A6
            // 
            this.A6.AutoSize = true;
            this.A6.Location = new System.Drawing.Point(356, 493);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(29, 13);
            this.A6.TabIndex = 40;
            this.A6.Text = "NuN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "GPIOA.0 Isens - вход с токового датчика";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "GPIOA.4 Uzpt - вход, напряжение звена постоянного тока";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(275, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "GPIOA.5 Un \t- выходное напряжение. обратная связь";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 493);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(256, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "GPIOA.6 Ibreak - ток отсечки. защитная функция.";
            // 
            // label_telemetry
            // 
            this.label_telemetry.AutoSize = true;
            this.label_telemetry.Location = new System.Drawing.Point(356, 394);
            this.label_telemetry.Name = "label_telemetry";
            this.label_telemetry.Size = new System.Drawing.Size(29, 13);
            this.label_telemetry.TabIndex = 45;
            this.label_telemetry.Text = "NuN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Слово состояния";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "ацп";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "ацп";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "ацп";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "ацп";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(569, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "мкА";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(569, 493);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "А";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(569, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "В";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(569, 470);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "КВ";
            // 
            // M9
            // 
            this.M9.AutoSize = true;
            this.M9.Location = new System.Drawing.Point(515, 422);
            this.M9.Name = "M9";
            this.M9.Size = new System.Drawing.Size(29, 13);
            this.M9.TabIndex = 55;
            this.M9.Text = "NuN";
            // 
            // M10
            // 
            this.M10.AutoSize = true;
            this.M10.Location = new System.Drawing.Point(515, 445);
            this.M10.Name = "M10";
            this.M10.Size = new System.Drawing.Size(29, 13);
            this.M10.TabIndex = 56;
            this.M10.Text = "NuN";
            // 
            // M11
            // 
            this.M11.AutoSize = true;
            this.M11.Location = new System.Drawing.Point(515, 470);
            this.M11.Name = "M11";
            this.M11.Size = new System.Drawing.Size(29, 13);
            this.M11.TabIndex = 57;
            this.M11.Text = "NuN";
            // 
            // M12
            // 
            this.M12.AutoSize = true;
            this.M12.Location = new System.Drawing.Point(515, 493);
            this.M12.Name = "M12";
            this.M12.Size = new System.Drawing.Size(29, 13);
            this.M12.TabIndex = 58;
            this.M12.Text = "NuN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 583);
            this.Controls.Add(this.M12);
            this.Controls.Add(this.M11);
            this.Controls.Add(this.M10);
            this.Controls.Add(this.M9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_telemetry);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_U_zpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_threshold_U_zpt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label A0;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_telemetry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label M9;
        private System.Windows.Forms.Label M10;
        private System.Windows.Forms.Label M11;
        private System.Windows.Forms.Label M12;
        private System.Windows.Forms.Label label_state_rele;
    }
}

