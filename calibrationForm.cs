using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGrapher
{
    public partial class calibrationForm : Form
    {
        string temp_one_offset_sign;
        string temp_two_offset_sign;
        string temp_three_offset_sign;
        string temp_four_offset_sign;

        string temp_one_offset;
        string temp_two_offset;
        string temp_three_offset;
        string temp_four_offset;

        string turb_one_offset_sign;
        string turb_two_offset_sign;
        string turb_three_offset_sign;
        string turb_four_offset_sign;

        string turb_one_offset;
        string turb_two_offset;
        string turb_three_offset;
        string turb_four_offset;

        public calibrationForm()
        {
            InitializeComponent();
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (isoStore.FileExists("calibration.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("calibration.txt", System.IO.FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        String[] line = new string[16];
                        for (int i = 0; i < 16; i++)
                        {
                            line[i] = reader.ReadLine();
                        }
                        tempOneOffsetSign.Text = line[0];
                        tempOneOffsetTxtBox.Text = line[1];
                        tempTwoOffsetSign.Text = line[2];
                        tempTwoOffsetTxtBox.Text = line[3];
                        tempThreeOffsetSign.Text = line[4];
                        tempThreeOffsetTxtBox.Text = line[5];
                        tempFourOffsetSign.Text = line[6];
                        tempFourOffsetTxtBox.Text = line[7];
                        turbOneOffsetSign.Text = line[8];
                        turbOneOffsetTxtBox.Text = line[9];
                        turbTwoOffsetSign.Text = line[10];
                        turbTwoOffsetTxtBox.Text = line[11];
                        turbThreeOffsetSign.Text = line[12];
                        turbThreeOffsetTxtBox.Text = line[13];
                        turbFourOffsetSign.Text = line[14];
                        turbFourOffsetTxtBox.Text = line[15];

                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            temp_one_offset_sign = tempOneOffsetSign.Text;
            temp_one_offset = tempOneOffsetTxtBox.Text;
            temp_two_offset_sign = tempTwoOffsetSign.Text;
            temp_two_offset = tempTwoOffsetTxtBox.Text;
            temp_three_offset_sign = tempThreeOffsetSign.Text;
            temp_three_offset = tempThreeOffsetTxtBox.Text;
            temp_four_offset_sign = tempFourOffsetSign.Text;
            temp_four_offset = tempFourOffsetTxtBox.Text;
            turb_one_offset_sign = turbOneOffsetSign.Text;
            turb_one_offset = turbOneOffsetTxtBox.Text;
            turb_two_offset_sign = turbTwoOffsetSign.Text;
            turb_two_offset = turbTwoOffsetTxtBox.Text;
            turb_three_offset_sign = turbThreeOffsetSign.Text;
            turb_three_offset = turbThreeOffsetTxtBox.Text;
            turb_four_offset_sign = turbFourOffsetSign.Text;
            turb_four_offset = turbFourOffsetTxtBox.Text;

            if (temp_one_offset_sign == "" || temp_one_offset == "" || temp_two_offset_sign == "" || temp_two_offset == "" || temp_three_offset_sign == "" || temp_three_offset == "" || temp_four_offset_sign == "" || temp_four_offset == "" || turb_one_offset_sign == "" || turb_one_offset == "" || turb_two_offset_sign == "" || turb_two_offset == "" || turb_three_offset_sign == "" || turb_three_offset == "" || turb_four_offset_sign == "" || temp_four_offset == "")
            {
                MessageBox.Show(this, "Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if (isoStore.FileExists("calibration.txt"))
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("calibration.txt", FileMode.Open, isoStore))
                    {
                        using (StreamWriter writer = new StreamWriter(isoStream))
                        {
                            writer.WriteLine(temp_one_offset_sign);
                            writer.WriteLine(temp_one_offset);
                            writer.WriteLine(temp_two_offset_sign);
                            writer.WriteLine(temp_two_offset);
                            writer.WriteLine(temp_three_offset_sign);
                            writer.WriteLine(temp_three_offset);
                            writer.WriteLine(temp_four_offset_sign);
                            writer.WriteLine(temp_four_offset);
                            writer.WriteLine(turb_one_offset_sign);
                            writer.WriteLine(turb_one_offset);
                            writer.WriteLine(turb_two_offset_sign);
                            writer.WriteLine(turb_two_offset);
                            writer.WriteLine(turb_three_offset_sign);
                            writer.WriteLine(turb_three_offset);
                            writer.WriteLine(turb_four_offset_sign);
                            writer.WriteLine(turb_four_offset);
                        }
                        MessageBox.Show(this, "Calibration settings saved successfully.", "Calibration Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Calibration settings could not be saved.", "Calibration Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }


        }
    }
}
