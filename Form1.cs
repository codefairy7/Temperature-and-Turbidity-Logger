using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace TTGrapher
{
    public partial class Form1 : Form
    {
        string comport = "COM0";
        string rec_interval = "";
        string[] line;
        string[] calibration;
        string filename = "";
        string filepath = "";
        string fullpath = "";
        int log_interval = 60;
        int conn_status = 0;
        Timer devTimer;
        Timer fileTimer;
        string temp1, turb1, temp2, turb2, temp3, turb3, temp4, turb4;
        double temp_one, temp_two, temp_three, temp_four;
        double turb_one, turb_two, turb_three, turb_four;
        string temp_one_offset_sign;
        string temp_two_offset_sign;
        string temp_three_offset_sign;
        string temp_four_offset_sign;

        double temp_one_offset;
        double temp_two_offset;
        double temp_three_offset;
        double temp_four_offset;

        string turb_one_offset_sign;
        string turb_two_offset_sign;
        string turb_three_offset_sign;
        string turb_four_offset_sign;

        double turb_one_offset;
        double turb_two_offset;
        double turb_three_offset;
        double turb_four_offset;


        public Form1()
        {
            InitializeComponent();
            loadSettings();
            statusLabel.Text = "Device Ready.";
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        public void loadSettings()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (isoStore.FileExists("config.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("config.txt", System.IO.FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        line = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            line[i] = reader.ReadLine();
                        }
                        comport = line[0];
                        rec_interval = line[1];
                        filepath = line[2];
                        log_interval = 60 * Int16.Parse(rec_interval);
                    }
                }
            }
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("config.txt", FileMode.CreateNew, isoStore))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        writer.WriteLine("COM0");
                        writer.WriteLine("1");
                        writer.WriteLine("C:\\");
                    }
                }
            }

            IsolatedStorageFile isoStore1 = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (isoStore.FileExists("calibration.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("calibration.txt", System.IO.FileMode.Open, isoStore1))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        calibration = new string[16];
                        for (int i = 0; i < 16; i++)
                        {
                            calibration[i] = reader.ReadLine();
                        }
                        temp_one_offset_sign = calibration[0];
                        temp_one_offset = Convert.ToDouble(calibration[1]);
                        temp_two_offset_sign = calibration[2];
                        temp_two_offset = Convert.ToDouble(calibration[3]);
                        temp_three_offset_sign = calibration[4];
                        temp_three_offset = Convert.ToDouble(calibration[5]);
                        temp_four_offset_sign = calibration[6];
                        temp_four_offset = Convert.ToDouble(calibration[7]);
                        turb_one_offset_sign = calibration[8];
                        turb_one_offset = Convert.ToDouble(calibration[9]);
                        turb_two_offset_sign = calibration[10];
                        turb_two_offset = Convert.ToDouble(calibration[11]);
                        turb_three_offset_sign = calibration[12];
                        turb_three_offset = Convert.ToDouble(calibration[13]);
                        turb_four_offset_sign = calibration[14];
                        turb_four_offset = Convert.ToDouble(calibration[15]);
                    }
                }
            }
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("calibration.txt", FileMode.CreateNew, isoStore))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");
                        writer.WriteLine("+");
                        writer.WriteLine("0");

                    }
                }
            }
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectionForm = new connectionForm();
            connectionForm.ShowDialog();
        }

        private void calibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calibrationForm = new calibrationForm();
            calibrationForm.ShowDialog();
        }
        private void generateGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generateGraphForm = new generateGraphForm();
            generateGraphForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Temperature and Turbidity Logger \n\nManufactured by: GP Systems \nPowered by: Blackwatt Technologies.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int connectionCheck()
        {
            int status = 0;
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = comport;
            serialPort.BaudRate = 19200;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.Two;

            try
            {
                serialPort.Open();
                IModbusMaster master = ModbusSerialMaster.CreateRtu(serialPort);
                status = 1;
                serialPort.Close();
            }
            catch(Exception ex)
            {
                status = 0;
            }
            serialPort.Close();
            return status;
        }

        public void createFile()
        {
            string cur_date = DateTime.Now.ToShortDateString();
            string name = cur_date.Replace('-', '_').Replace(' ', '_').Replace(" ", "").Replace(":", "_");
            filename = "log_" + name + ".csv";
            fullpath = Path.Combine(filepath, filename);
            if (File.Exists(fullpath))
            {
                Console.WriteLine("The file exists");
            }
            else
            {
                var csv = new StringBuilder();
                var header = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\"", "Time", "Temperature1", "Turbidity1", "Temperature2", "Turbidity2", "Temperature3", "Turbidity3", "Temperature4", "Turbidity4");
                csv.AppendLine(header);
                File.AppendAllText(fullpath, csv.ToString());
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            conn_status = connectionCheck();
            loadSettings();
            if (conn_status == 1)
            {
                createFile();
                devTimer = new Timer();
                devTimer.Interval = log_interval  * 1000;
                devTimer.Tick += new EventHandler(devTimer_Tick);
                devTimer.Start();
                statusLabel.Text = "Device detected. Reading data...";

                fileTimer = new Timer();
                fileTimer.Interval = log_interval * 1000 + 1000;
                fileTimer.Tick += new EventHandler(fileTimer_Tick);
                fileTimer.Start();

                stopBtn.Enabled = true;
                startBtn.Enabled = false;
            }
            else
            {
                statusLabel.Text = "Device not detected. Could not read data...";
            }
        }
        public void fileTimer_Tick(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            DateTime dt = DateTime.Now;
            string cur_time = dt.ToString("G");
            var newline = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", cur_time, temp1, turb1, temp2, turb2, temp3, turb3, temp4, turb4);
            csv.AppendLine(newline);
            File.AppendAllText(fullpath, csv.ToString());
        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            devTimer.Stop();
            fileTimer.Stop();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        private void devTimer_Tick(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = comport;
            serialPort.BaudRate = 19200;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.Two;
            serialPort.ReadTimeout = 100;

            try
            {
                serialPort.Open();
                IModbusMaster master = ModbusSerialMaster.CreateRtu(serialPort);
                byte slave_id_one = 1;
                byte slave_id_two = 2;
                byte slave_id_three = 3;
                byte slave_id_four = 4;

                ushort startAddress = 1538;
                ushort numRegisters = 5;
                
                ushort[] device_one = master.ReadInputRegisters(slave_id_one, startAddress, numRegisters);
                ushort[] device_two = master.ReadInputRegisters(slave_id_two, startAddress, numRegisters);
                ushort[] device_three = master.ReadInputRegisters(slave_id_three, startAddress, numRegisters);
                ushort[] device_four = master.ReadInputRegisters(slave_id_four, startAddress, numRegisters);

                if (calibration[0] == "+")
                {
                    temp_one = (device_one[0] / 10.0) + Convert.ToDouble(calibration[1]);
                }
                if (calibration[0] == "-")
                {
                    temp_one = (device_one[0] / 10.0) - Convert.ToDouble(calibration[1]);
                }
                temp1 = temp_one.ToString();

                if (calibration[2] == "+")
                {
                    temp_two = (device_two[0] / 10.0) + Convert.ToDouble(calibration[3]);
                }
                if (calibration[2] == "-")
                {
                    temp_two = (device_two[0] / 10.0) - Convert.ToDouble(calibration[3]);
                }
                temp2 = temp_two.ToString();

                if (calibration[4] == "+")
                {
                    temp_three = (device_three[0] / 10.0) + Convert.ToDouble(calibration[5]);
                }
                if (calibration[4] == "-")
                {
                    temp_three = (device_three[0] / 10.0) - Convert.ToDouble(calibration[5]);
                }
                temp3 = temp_three.ToString();

                if (calibration[6] == "+")
                {
                    temp_four = (device_four[0] / 10.0) + Convert.ToDouble(calibration[7]);
                }
                if (calibration[6] == "-")
                {
                    temp_four = (device_four[0] / 10.0) - Convert.ToDouble(calibration[7]);
                }
                temp4 = temp_four.ToString();

                if (calibration[8] == "+")
                {
                    turb_one = ((device_one[4] * 20)/1000) + Convert.ToDouble(calibration[9]);
                }
                if (calibration[8] == "-")
                {
                    turb_one = ((device_one[4] * 20)/1000) - Convert.ToDouble(calibration[9]);
                }
                turb1 = turb_one.ToString();

                if (calibration[10] == "+")
                {
                    turb_two = ((device_two[4] * 20)/1000) + Convert.ToDouble(calibration[11]);
                }
                if (calibration[10] == "-")
                {
                    turb_two = ((device_two[4] * 20) / 1000) - Convert.ToDouble(calibration[11]);
                }
                turb2 = turb_two.ToString();

                if (calibration[12] == "+")
                {
                    turb_three = ((device_three[4] * 20) / 1000) + Convert.ToDouble(calibration[13]);
                }
                if (calibration[12] == "-")
                {
                    turb_three = ((device_three[4] * 20) / 1000) - Convert.ToDouble(calibration[13]);
                }
                turb3 = turb_three.ToString();

                if (calibration[14] == "+")
                {
                    turb_four = ((device_four[4] * 20) / 1000)  + Convert.ToDouble(calibration[15]);
                }
                if (calibration[14] == "-")
                {
                    turb_four = ((device_four[4] * 20) / 1000) - Convert.ToDouble(calibration[15]);
                }
                turb4 = turb_four.ToString();


                //display all the values on the labels
                tempOneVal.Text = temp1 + " °C";
                tempTwoVal.Text = temp2 + " °C";
                tempThreeVal.Text = temp3 + " °C";
                tempFourVal.Text = temp4 + " °C";

                turbOneVal.Text = turb1 + " NTU";
                turbTwoVal.Text = turb2 + " NTU";
                turbThreeVal.Text = turb3 + " NTU";
                turbFourVal.Text = turb4 + " NTU";

                //plot all values on the graphs
                chartOne.Series["Series1"].Points.AddXY(temp1, turb1);
                chartTwo.Series["Series1"].Points.AddXY(temp2, turb2);
                chartThree.Series["Series1"].Points.AddXY(temp3, turb3);
                chartFour.Series["Series1"].Points.AddXY(temp4, turb4);

            }
            catch (Exception ex)
            {
                statusLabel.Text = "Device Disconnected.";
            }

            serialPort.Close();
        }
    }


}
