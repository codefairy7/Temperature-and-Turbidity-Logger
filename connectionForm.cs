using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGrapher
{
    public partial class connectionForm : Form
    {
        string port = "";
        string comport = "";
        string interval = "";
        string filepath = "";

        public connectionForm()
        {
            InitializeComponent();
            for(int i=0;i<256;i++)
            {
                comportBox.Items.Add("COM" + i);
            }
            string[] ports = SerialPort.GetPortNames();
            if(ports.Length == 0)
            {
                comportBox.Text = "COM0";
            } else
            {
                comportBox.Text = ports[0];
                port = ports[0];
            }

            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (isoStore.FileExists("config.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("config.txt", System.IO.FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        String[] line = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            line[i] = reader.ReadLine();
                        }
                        comportBox.Text = line[0];
                        intervalTxtBox.Text = line[1];
                        locationTxtBox.Text = line[2];  
                    }
                        
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if(result == DialogResult.OK)
            {
                locationTxtBox.Text = folderDlg.SelectedPath;
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            if(comportBox.Text == "" || locationTxtBox.Text == "" || intervalTxtBox.Text == "")
            {
                MessageBox.Show(this, "Please provide all information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SerialPort serialPort = new SerialPort();
                serialPort.PortName = comportBox.Text;
                serialPort.BaudRate = 19200;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.Two;

                try
                {
                    serialPort.Open();
                    MessageBox.Show(this, "Connection established successfully.", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    serialPort.Close();
                } catch(Exception ex)
                {
                    MessageBox.Show(this, "Connection could not be established.", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            comport = comportBox.Text;
            filepath = locationTxtBox.Text;
            interval = intervalTxtBox.Text;

            if (comport == "" || filepath == "" || interval == "")
            {
                MessageBox.Show(this, "Please provide all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if(isoStore.FileExists("config.txt"))
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("config.txt", FileMode.Open, isoStore))
                    {
                        using (StreamWriter writer = new StreamWriter(isoStream))
                        {
                            writer.WriteLine(comport);
                            writer.WriteLine(interval);
                            writer.WriteLine(filepath);
                        }
                        MessageBox.Show(this, "Connection Settings saved successfully", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Connection settings couldn't be saved successfully.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
