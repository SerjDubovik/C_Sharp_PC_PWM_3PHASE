using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Modbus.Device;


namespace C_Sharp_PC_PWM_3PHASE
{
	public partial class Form1
    {		
		
		
		public void connect_modbus()
		{									
					
			serialPort.PortName 	= post_buf;									// СОМ порт для каждого канала
			serialPort.BaudRate 	= Convert.ToInt32(speed_net_buf);			// скорость передачи по выбранному каналу модбас
			serialPort.DataBits 	= Convert.ToInt32(quantity_bit_buf);		// кол-во бит в посылке

			
			switch (parity_net_buf)												// проверка на чётность
			{
				case "Even": serialPort.Parity 		= 	Parity.Even;	break;
				case "Mark": serialPort.Parity 		= 	Parity.Mark;	break;
				case "None": serialPort.Parity 		= 	Parity.None;	break;
				case "Odd": serialPort.Parity 		= 	Parity.Odd;		break;
				case "Space": serialPort.Parity 	= 	Parity.Space;	break;			
			}
			
			
			
			switch (stop_bit_net_buf)											// кол-во стоп бит
			{
				case "None":  serialPort.StopBits				=	StopBits.None;	break;
				case "One":  serialPort.StopBits				=	StopBits.One;	break;
				case "OnePointFive":  serialPort.StopBits		=	StopBits.OnePointFive;	break;
				case "Two":  serialPort.StopBits				=	StopBits.Two;	break;								
										
			}

            try
            {
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.Retries = 0;       // don't have to do retries
                master.Transport.ReadTimeout = 50; // milliseconds

                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Открыт ";              // выводим сообщение в строку состояния
                
        

            }

            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Не удалось открыть ";  // выводим сообщение в строку состояния
            }


            try
            {
            	Thread_Modbus.Start(modBus_var);                                 // запуск процесса обработки ком порта
                toolStripStatusLabel4.Text = " Поток запущен ";                  // выводим сообщение в строку состояния

            }
            catch (Exception)
            {
                toolStripStatusLabel4.Text = " Поток не запущен ";               // выводим сообщение в строку состояния
            }
            
		}
		
		
		
		
		
		
		public static void Modbus_func(object obj)                                     // метод потока. для работы с ком портом
		{

			ModBus_var modBus_var = (ModBus_var)obj;
			
			bool enable_loop = true;
						

			
            while (enable_loop)														// не забываем за бесконечный цикл в потоках =)
            {    

            	if(enable_loop == false)
            	{
            		break;
            	}
            	
    	        try
                {
					
                    ushort[] register;

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 0, 2);           //  телеметрия состояния контроллера
					modBus_var.mb_mass[0] = register[0];

					// 15	-	1 если включился и ждёт команды от пользователя.
					// 14	-	
					// 13	-	
					// 12	-	
					// 11	-	
					// 10	-	
					// 9	-	
					// 8	-	

					// 7	-	
					// 6	-	
					// 5	-	
					// 4	-	
					// 3	-	
					// 2	-	
					// 1	-	
					// 0	-	


					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 8, 2);           // счётчик для проверки связи
                    modBus_var.mb_mass[8] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 9, 2);           // GPIOA.0		Isens - вход с токового датчика
					modBus_var.mb_mass[9] = register[0];
					
					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 10, 2);          // GPIOA.4		Uzpt - вход, напряжение звена постоянного тока
					modBus_var.mb_mass[10] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 11, 2);          // GPIOA.5		Un 	- выходное напряжение. обратная связь
					modBus_var.mb_mass[11] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 12, 2);          // GPIOA.6		Ibreak - ток отсечки. защитная функция.
					modBus_var.mb_mass[12] = register[0];



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 13, 2);          // GPIOA.0		Isens значение АЦП без пересчёта
					modBus_var.mb_mass[13] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 14, 2);          // GPIOA.4		Uzpt значение АЦП без пересчёта
					modBus_var.mb_mass[14] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 15, 2);          // GPIOA.5		Un значение АЦП без пересчёта
					modBus_var.mb_mass[15] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 16, 2);          // GPIOA.6		Ibreak значение АЦП без пересчёта
					modBus_var.mb_mass[16] = register[0];



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 17, 2);          // Коэффициент для пересчёта из АЦП в Амперы тока выхода.Телеметрия, мастер только читает.
					modBus_var.mb_mass[17] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 18, 2);          // Коэффициент для пересчёта из АЦП в Вольт ЗПТ. Телеметрия, мастер только читает.
					modBus_var.mb_mass[18] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 19, 2);          // Коэффициент для пересчёта из АЦП в Вольт выхода. Телеметрия, мастер только читает.
					modBus_var.mb_mass[19] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 20, 2);          // Коэффициент для пересчёта из АЦП в Амперы на ключе.Телеметрия, мастер только читает.
					modBus_var.mb_mass[20] = register[0];



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 21, 2);          // Нижнее пороговое значение напряжения ЗПТ. Порог срабатывания реле ЗПТ. Телеметрия, мастер не меняет это значение
					modBus_var.mb_mass[21] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 22, modBus_var.mb_mass[22]); // Нижнее пороговое значение напряжения ЗПТ. Порог срабатывания реле ЗПТ. Задание мастером, слейв не менят это значение




					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 23, 2);          // Текущая частота(кГц).
					modBus_var.mb_mass[23] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 24, modBus_var.mb_mass[24]);	// Задать частоту(кГц).



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 25, 2);          // Текущий дедтайм(ед).
					modBus_var.mb_mass[25] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 26, modBus_var.mb_mass[26]); // Задать дедтайм(ед).



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 27, 2);          // Текуший ШИМ.
					modBus_var.mb_mass[27] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 28, modBus_var.mb_mass[28]); // Едениц задания ШИМ.


					master.WriteSingleRegister(modBus_var.adrr_dev_in, 29, modBus_var.mb_mass[29]); // Задать выходное напряжение(кВ).



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 30, 2);          // Текущее токоограничение(мА).
					modBus_var.mb_mass[30] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 31, modBus_var.mb_mass[31]); // Задать токоограничение(мА):



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 32, 2);          // Температура платы управления(С).
					modBus_var.mb_mass[32] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 33, 2);          // Порог платы управления(С).
					modBus_var.mb_mass[33] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 34, modBus_var.mb_mass[34]); // Задать порог платы(С).




					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 35, 2);          // Температура радиатора(С).
					modBus_var.mb_mass[35] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 36, 2);          // Порог радиатора(С).
					modBus_var.mb_mass[36] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 37, modBus_var.mb_mass[37]);	// Задать порог радиатора(С).


					master.WriteSingleRegister(modBus_var.adrr_dev_in, 38, modBus_var.mb_mass[38]); // Коэффициент для пересчёта из АЦП в Амперы тока выхода.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 39, modBus_var.mb_mass[39]); // Коэффициент для пересчёта из АЦП в Вольт ЗПТ. Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 40, modBus_var.mb_mass[40]); // Коэффициент для пересчёта из АЦП в Вольт выхода. Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 41, modBus_var.mb_mass[41]); // Коэффициент для пересчёта из АЦП в Амперы на ключе.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):


					master.WriteSingleRegister(modBus_var.adrr_dev_in, 42, modBus_var.mb_mass[42]); // Делитель для преобразования из целого в дробное.Для тока выхода.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 43, modBus_var.mb_mass[43]); // Делитель для преобразования из целого в дробное.Для напряжения ЗПТ.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 44, modBus_var.mb_mass[44]); // Делитель для преобразования из целого в дробное.Для напряжения выхода.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 45, modBus_var.mb_mass[45]); // Делитель для преобразования из целого в дробное.Для тока отсечки.Мастер задаёт это значение. Код для подтверждения(запись в адрес 2):


					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 46, 2);          // Делитель для преобразования из целого в дробное.Для тока выхода.Мастер читает это значение и формирует дробное число для отображения.
					modBus_var.mb_mass[46] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 47, 2);          // Делитель для преобразования из целого в дробное.Для напряжения ЗПТ.Мастер читает это значение и формирует дробное число для отображения.
					modBus_var.mb_mass[47] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 48, 2);          // Делитель для преобразования из целого в дробное.Для напряжения выхода.Мастер читает это значение и формирует дробное число для отображения.
					modBus_var.mb_mass[48] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 49, 2);          // Делитель для преобразования из целого в дробное.Для тока отсечки.Мастер читает это значение и формирует дробное число для отображения.
					modBus_var.mb_mass[49] = register[0];


					master.WriteSingleRegister(modBus_var.adrr_dev_in, 1, modBus_var.mb_mass[1]);   //  запись управляющего слова
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 2, modBus_var.mb_mass[2]);


					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 3, 2);           // слейв пишет в этот адрес код команды слейву
					modBus_var.mb_mass[3] = register[0];

					if (modBus_var.mb_mass[3] == 1)
					{
						modBus_var.mb_mass[2] = 0;
					}

				}

				catch 
				{

				}
            	               	
            }
			
        }
		
	}
	
}