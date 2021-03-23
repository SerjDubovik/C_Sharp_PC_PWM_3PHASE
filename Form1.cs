using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;
using Modbus.Device;    															        // for modbus master
using System.IO.Ports;  															        // for serial port
using System.Threading;
using System.Text;


namespace C_Sharp_PC_PWM_3PHASE
{
    public partial class Form1 : Form
    {


		public List<string> existing_port_list = new List<string>() { "Не использовать" };  // лист доступных в системе СОМ портов в данный момент

		public string nomber_net_buf;                                                       // номер устройства в сети
		public string speed_net_buf;                                                        // скорость передачи по выбранному каналу модбас
		public string stop_bit_net_buf;                                                     // кол-во стоп бит
		public string quantity_bit_buf;                                                     // кол-во бит в посылке
		public string parity_net_buf;                                                   // выбранная проверка в посылке
		public string post_buf;                                                             // СОМ порт для канала связи

		public bool autoconnect_buf;                                                    // буль если тру, то прога самоподключается при старте

		public static ushort[] modbus_mass = new ushort[200];                               // массив для взаимодействия с потоком обработки модбас

		public Property_Form property_Form;                                                 // Объявляем класс с формой настроек				

		public Class_visu_prop_grid_modbus visu_MyClass_modbus = new Class_visu_prop_grid_modbus(); // создаём экземпляр класса для отображения в сетке свойств настроек modbus

		public Serializable_Class serializable_Class;

		public SerialPort serialPort = new SerialPort();                                           // create a new SerialPort object with default settings.			

		public ModBus_var modBus_var = new ModBus_var();                                    // создаём экземпляр класса для передачи в поток
		public Thread Thread_Modbus = new Thread(new ParameterizedThreadStart(Modbus_func));       // Вот так передаём в созданный поток класс

		public static ModbusSerialMaster master;


		public Form1()
        {
            InitializeComponent();

			serializable_Class = new Serializable_Class(            // инициируем класс для работы с сериализером
								nomber_net_buf,                     // номер устройства в сети
								speed_net_buf,                      // скорость передачи по выбранному каналу модбас
								stop_bit_net_buf,                   // кол-во стоп бит
								quantity_bit_buf,                   // кол-во бит в посылке
								parity_net_buf,                     // выбранная проверка в посылке
								post_buf,
								autoconnect_buf);

			Deserialization("default.dat");                         // десериализуем ранее сохранённые настройки




			property_Form = new Property_Form(this);
			property_Form.Tag = this;


			existing_port_list.AddRange(SerialPort.GetPortNames());                     // узнаём какие порты активны сейчс и заносим их в лист

			checkBox1.Checked = true;													// при старте выставлена галка автономной работы

			if (checkBox2.Checked)
			{
				label_state_rele.Text = "Реле замкнуто";
				label_state_rele.BackColor = Color.FromArgb(128, 255, 128);
			}
			else
			{
				label_state_rele.Text = "Реле разомкнуто";
				label_state_rele.BackColor = Color.FromArgb(255, 128, 128);
			}


		}

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
			Serialization("default.dat");
			Thread_Modbus.Abort();                                                          // заставляет прервать поток обработки модбас	
			Close();
		}

        private void ToolStripMenuItem_transport_btn_Click(object sender, EventArgs e)
        {
			property_Form.tabControl1.SelectTab(0);                                         // показываем окно с первой вкладки
			property_Form.Show();                                                           // показываем окно	
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			Serialization("default.dat");
			Thread_Modbus.Abort();                                                      // заставляет прервать поток обработки модбас
		}

        private void timer_for_Displ_Tick(object sender, EventArgs e)
        {			
			toolStripStatusLabel7.Text = Convert.ToString(modBus_var.mb_mass[8]);       // тестовый счётчик в потоке модбаса в плате. в строке состояния.


			A0.Text = Convert.ToString(modBus_var.mb_mass[13]);							// GPIOA.0		Isens - вход с токового датчика
			A4.Text = Convert.ToString(modBus_var.mb_mass[14]);							// GPIOA.4		Uzpt - вход, напряжение звена постоянного тока
			A5.Text = Convert.ToString(modBus_var.mb_mass[15]);							// GPIOA.5		Un 	- выходное напряжение. обратная связь
			A6.Text = Convert.ToString(modBus_var.mb_mass[16]);							// GPIOA.6		Ibreak - ток отсечки. защитная функция.

			M9.Text = Convert.ToString(modBus_var.mb_mass[9]/1000.0);					// Isens * K_Isens
			M10.Text = Convert.ToString(modBus_var.mb_mass[10]);						// Uzpt * K_Uzpt
			M11.Text = Convert.ToString(modBus_var.mb_mass[11]/1000.0);                 // Un * K_Un
			M12.Text = Convert.ToString(modBus_var.mb_mass[12]/100.0);					// Ibreak * K_Ibreak
			
			M21.Text = Convert.ToString(modBus_var.mb_mass[21]);                        // Порог срабатыания реле ЗПТ
			M23.Text = Convert.ToString(modBus_var.mb_mass[23]);                        // Текущая частота(кГц).
			M25.Text = Convert.ToString(modBus_var.mb_mass[25]);                        // Текущий дедтайм (ед).
			M27.Text = Convert.ToString(modBus_var.mb_mass[27]);                        // Текущий ШИМ.
			M30.Text = Convert.ToString(modBus_var.mb_mass[30]);                        // Текущее токоограничение (мА).
			M32.Text = Convert.ToString(modBus_var.mb_mass[32]);                        // Температура платы управления (С).
			M33.Text = Convert.ToString(modBus_var.mb_mass[33]);                        // Порог платы управления (С).
			M35.Text = Convert.ToString(modBus_var.mb_mass[35]);                        // Температура радиатора (С).
			M36.Text = Convert.ToString(modBus_var.mb_mass[33]);                        // Порог радиатора (С).
			M50.Text = Convert.ToString(modBus_var.mb_mass[50]);                        // Текущая скважность.
			M52.Text = Convert.ToString(modBus_var.mb_mass[52]);                        // Текущая скважность Buck-конвертора.

			label_control.Text = Convert.ToString(modBus_var.mb_mass[1]);				// слово управления
			label_telemetry.Text = Convert.ToString(modBus_var.mb_mass[0]);             // состояние системы




			if ((modBus_var.mb_mass[0] &= 0x4000) != 0)//
			{
				label_state_rele.Text = "Реле замкнуто";
				label_state_rele.BackColor = Color.FromArgb(128, 255, 128);
				//checkBox2.Checked = true;
			}
			else
			{
				label_state_rele.Text = "Реле разомкнуто";
				label_state_rele.BackColor = Color.FromArgb(255, 128, 128);
				//checkBox2.Checked = false;
			}

		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)			// принудительно замкнуть реле
        {
			if (checkBox2.Checked)													// замкнуть реле
			{
				modBus_var.mb_mass[1] &= 0xDFFF;
				modBus_var.mb_mass[1] |= 0x4000;
			}
			else																	// разомкнуть реле
			{
				modBus_var.mb_mass[1] &= 0xBFFF;
				modBus_var.mb_mass[1] |= 0x2000;				
			}
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)			// автономная работа
        {
			if (checkBox1.Checked)
			{
				modBus_var.mb_mass[1] |= 0x1000;									// установим 12 бит, автономная работа зпт

				checkBox2.Hide();
			}
			else
			{
				modBus_var.mb_mass[1] &= 0xEFFF;                                    // сбросим 12 бит, переход на ручной режим

				if ((modBus_var.mb_mass[0] &= 0x4000) != 0)							// если в момент перехода на ручное управление, реле было замкнуто, выставим галку.
				{
					checkBox2.Checked = true;
				}
				else
				{
					checkBox2.Checked = false;
				}

				checkBox2.Show();
			}
		}

        private void checkBox4_CheckedChanged(object sender, EventArgs e)			// включить/выключить шим
        {
			if (checkBox4.Checked)                                                  // 
			{

			}
			else                                                                    // 
			{

			}
		}


        private void button_set_ZPT_threshold_Click(object sender, EventArgs e)		// кнопка задания порога срабатывания зпт.
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[22] = Convert.ToUInt16(numericUpDown1.Value);   // 
				modBus_var.mb_mass[2] = 10;
			}
			else 
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
			
		}

        private void button_set_freq_threshold_Click(object sender, EventArgs e)	// задает частоту следования импульсов
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[24] = Convert.ToUInt16(numericUpDown3.Value);   // 
				modBus_var.mb_mass[2] = 11;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

        private void button_set_dedtime_Click(object sender, EventArgs e)			// задаёт дедтайм
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[26] = Convert.ToUInt16(numericUpDown6.Value);   // 
				modBus_var.mb_mass[2] = 12;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

        private void button_set_Uout_Click(object sender, EventArgs e)				// задать выходное напряжение
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[29] = Convert.ToUInt16(numericUpDown4.Value);   // 
				modBus_var.mb_mass[2] = 13;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}


        private void button_set_Iout_Click(object sender, EventArgs e)				// задать токоограничение выхода
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[31] = Convert.ToUInt16(numericUpDown5.Value);   // 
				modBus_var.mb_mass[2] = 14;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

        private void button_set_T_plate_threshold_Click(object sender, EventArgs e)	// задаёт порог срабатывания по температуре платы
        {
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[34] = Convert.ToUInt16(numericUpDown7.Value);   // 
				modBus_var.mb_mass[2] = 15;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

        private void button_set_T_heater_threshold_Click(object sender, EventArgs e) // задаёт порог срабатывания по температурерадиатора
		{
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[37] = Convert.ToUInt16(numericUpDown8.Value);   // 
				modBus_var.mb_mass[2] = 16;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[28] = Convert.ToUInt16(numericUpDown2.Value);   // 
				modBus_var.mb_mass[2] = 17;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked)                                                  // замкнуть реле
			{
				modBus_var.mb_mass[1] |= 0x8000;
			}
			else                                                                    // разомкнуть реле
			{
				modBus_var.mb_mass[1] &= 0x7FFF;
			}
		}

		private void numericUpDown16_ValueChanged(object sender, EventArgs e)
		{
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[51] = Convert.ToUInt16(numericUpDown16.Value);   // 
				modBus_var.mb_mass[2] = 18;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}

		private void numericUpDown17_ValueChanged(object sender, EventArgs e)
		{
			if (modBus_var.mb_mass[2] == 0)
			{
				modBus_var.mb_mass[53] = Convert.ToUInt16(numericUpDown17.Value);   // 
				modBus_var.mb_mass[2] = 19;
			}
			else
			{
				MessageBox.Show("Не торопись. Протокол за тобой не поспевает.");
			}
		}
	}







	public class ModBus_var
	{
		public byte adrr_dev_in;
		public ushort adrr_var_in;
		public ushort adrr_var_out;
		public ushort lenght_in;

		public ushort buton;

		public ushort flag_connect;
		public ushort flag_read_param;
		public ushort flag_write_param;

		public ushort[] mb_mass;


		public ModBus_var()
		{
			mb_mass = new ushort[200];

		}

	}
}
