using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TTGrapher
{
    public partial class generateGraphForm : Form
    {
        public generateGraphForm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select File";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "csv files | *.csv";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filepathTxtBox.Text = ofd.FileName;
            }
        }

        private void generateGraphBtn_Click(object sender, EventArgs e)
        {
            if (filepathTxtBox.Text == "")
            {
                MessageBox.Show("Please select a file to generate the graph.", "Message");
            }
            else if (!File.Exists(filepathTxtBox.Text))    
             {
                MessageBox.Show("The file you requested does not exist.", "Message");
            }
            else
            {
                    var reader = new StreamReader(File.OpenRead(filepathTxtBox.Text));
                    List<string> temp1 = new List<string>();
                    List<string> turb1 = new List<string>();
                    List<string> temp2 = new List<string>();
                    List<string> turb2 = new List<string>();
                    List<string> temp3 = new List<string>();
                    List<string> turb3 = new List<string>();
                    List<string> temp4 = new List<string>();
                    List<string> turb4 = new List<string>();
                    int i = 1;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (i == 1)
                        {
                            i = 0;
                        }
                        else
                        {
                            temp1.Add(values[1]);
                            turb1.Add(values[2]);
                            temp2.Add(values[3]);
                            turb2.Add(values[4]);
                            temp3.Add(values[5]);
                            turb3.Add(values[6]);
                            temp4.Add(values[7]);
                            turb4.Add(values[8]);
                        }
                    }

                    ChartArea area1 = new ChartArea();
                    area1.Name = "ChartArea1";
                    chart1.ChartAreas.Add(area1);

                    ChartArea area2 = new ChartArea();
                    area2.Name = "ChartArea2";
                    chart1.ChartAreas.Add(area2);

                    ChartArea area3 = new ChartArea();
                    area3.Name = "ChartArea3";
                    chart1.ChartAreas.Add(area3);

                    ChartArea area4 = new ChartArea();
                    area4.Name = "ChartArea4";
                    chart1.ChartAreas.Add(area4);

                    Series series1 = new Series();
                    series1.Name = "Series1";
                    series1.ChartArea = "ChartArea1";
                    chart1.Series.Add(series1);

                    Series series2 = new Series();
                    series2.Name = "Series2";
                    series2.ChartArea = "ChartArea2";
                    chart1.Series.Add(series2);

                    Series series3 = new Series();
                    series3.Name = "Series3";
                    series3.ChartArea = "ChartArea3";
                    chart1.Series.Add(series3);

                    Series series4 = new Series();
                    series4.Name = "Series4";
                    series4.ChartArea = "ChartArea4";
                    chart1.Series.Add(series4);

                    series1.ChartType = SeriesChartType.Line;
                    series2.ChartType = SeriesChartType.Line;
                    series3.ChartType = SeriesChartType.Line;
                    series4.ChartType = SeriesChartType.Line;



                    Axis xAxis1 = chart1.ChartAreas[0].AxisX;
                    Axis xAxis2 = chart1.ChartAreas[1].AxisX;
                    Axis xAxis3 = chart1.ChartAreas[2].AxisX;
                    Axis xAxis4 = chart1.ChartAreas[3].AxisX;
                    xAxis1.Title = "Temperature (°C)";
                    xAxis2.Title = "Temperature (°C)";
                    xAxis3.Title = "Temperature (°C)";
                    xAxis4.Title = "Temperature (°C)";

                    Axis yAxis1 = chart1.ChartAreas[0].AxisY;
                    Axis yAxis2 = chart1.ChartAreas[1].AxisY;
                    Axis yAxis3 = chart1.ChartAreas[2].AxisY;
                    Axis yAxis4 = chart1.ChartAreas[3].AxisY;
                    yAxis1.Title = "Turbidity [NTU]";
                    yAxis2.Title = "Turbidity [NTU]";
                    yAxis3.Title = "Turbidity [NTU]";
                    yAxis4.Title = "Turbidity [NTU]";

                    for (int t = 0; t < temp1.Count; t++)
                    {
                        chart1.Series["Series1"].Points.AddXY(Convert.ToDouble(temp1[t]), Convert.ToDouble(turb1[t]));
                    }

                    for (int t = 0; t < temp2.Count; t++)
                    {
                        chart1.Series["Series2"].Points.AddXY(Convert.ToDouble(temp2[t]), Convert.ToDouble(turb2[t]));
                    }

                    for (int t = 0; t < temp3.Count; t++)
                    {
                        chart1.Series["Series3"].Points.AddXY(Convert.ToDouble(temp3[t]), Convert.ToDouble(turb3[t]));
                    }
                    for (int t = 0; t < temp4.Count; t++)
                    {
                        chart1.Series["Series4"].Points.AddXY(Convert.ToDouble(temp4[t]), Convert.ToDouble(turb4[t]));
                    }
                }


        }

        private void saveGraphBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\\";
            saveFileDialog1.Title = "Save Graph";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "Image Files (*.png)|*.png";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
                MessageBox.Show("Graph saved successfully.", "Message");              
            }
            
            
        }
    }
}
