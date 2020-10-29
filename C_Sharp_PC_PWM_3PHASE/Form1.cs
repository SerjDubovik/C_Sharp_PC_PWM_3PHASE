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
			Thread_Modbus.Abort();                                                          // заставляет прервать поток обработки модбас
		}

        private void timer_for_Displ_Tick(object sender, EventArgs e)
        {
			label_count_connect.Text = Convert.ToString(modBus_var.mb_mass[8]);			// тестовый счётчик в потоке модбаса в плате
			
			A0.Text = Convert.ToString(modBus_var.mb_mass[13]);							// GPIOA.0		Isens - вход с токового датчика
			A4.Text = Convert.ToString(modBus_var.mb_mass[14]);							// GPIOA.4		Uzpt - вход, напряжение звена постоянного тока
			A5.Text = Convert.ToString(modBus_var.mb_mass[15]);							// GPIOA.5		Un 	- выходное напряжение. обратная связь
			A6.Text = Convert.ToString(modBus_var.mb_mass[16]);							// GPIOA.6		Ibreak - ток отсечки. защитная функция.

			M9.Text = Convert.ToString(modBus_var.mb_mass[9]/1000.0);					// Isens * K_Isens
			M10.Text = Convert.ToString(modBus_var.mb_mass[10]);						// Uzpt * K_Uzpt
			M11.Text = Convert.ToString(modBus_var.mb_mass[11]/1000.0);                 // Un * K_Un
			M12.Text = Convert.ToString(modBus_var.mb_mass[12]/100.0);					// Ibreak * K_Ibreak

			label_U_zpt.Text = Convert.ToString(modBus_var.mb_mass[10]);				// Uzpt * K_Uzpt
			label_threshold_U_zpt.Text = Convert.ToString(modBus_var.mb_mass[21]);      // Порог срабатыания реле ЗПТ


			if ((modBus_var.mb_mass[0] &= 0x4000) != 0)
			{
				label_state_rele.Text = "Реле замкнуто";
				label_state_rele.BackColor = Color.FromArgb(128, 255, 128);
			}
			else
			{
				label_state_rele.Text = "Реле разомкнуто";
				label_state_rele.BackColor = Color.FromArgb(255, 128, 128);
			}

			label_telemetry.Text = Convert.ToString(modBus_var.mb_mass[0]);				// состояние системы

		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)			// принудительно замкнуть реле
        {
			if (checkBox2.Checked)
			{

			}
			else
			{

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
