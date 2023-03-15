namespace TTGrapher
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartOne = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTwo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThree = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tempOneVal = new System.Windows.Forms.Label();
            this.turbOneVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tempTwoVal = new System.Windows.Forms.Label();
            this.turbTwoVal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tempThreeVal = new System.Windows.Forms.Label();
            this.turbThreeVal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tempFourVal = new System.Windows.Forms.Label();
            this.turbFourVal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFour)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.calibrationToolStripMenuItem,
            this.generateGraphToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // calibrationToolStripMenuItem
            // 
            this.calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            this.calibrationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calibrationToolStripMenuItem.Text = "Offset";
            this.calibrationToolStripMenuItem.Click += new System.EventHandler(this.calibrationToolStripMenuItem_Click);
            // 
            // generateGraphToolStripMenuItem
            // 
            this.generateGraphToolStripMenuItem.Name = "generateGraphToolStripMenuItem";
            this.generateGraphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateGraphToolStripMenuItem.Text = "Generate Graph";
            this.generateGraphToolStripMenuItem.Click += new System.EventHandler(this.generateGraphToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartTwo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartThree, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartFour, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 409);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartOne
            // 
            this.chartOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Title = "Temperature [C]";
            chartArea5.AxisY.Title = "Turbidity [NTU]";
            chartArea5.Name = "ChartArea1";
            this.chartOne.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOne.Legends.Add(legend5);
            this.chartOne.Location = new System.Drawing.Point(3, 3);
            this.chartOne.Name = "chartOne";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartOne.Series.Add(series5);
            this.chartOne.Size = new System.Drawing.Size(584, 198);
            this.chartOne.TabIndex = 0;
            this.chartOne.Text = "chart1";
            // 
            // chartTwo
            // 
            this.chartTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.Title = "Temperature [C]";
            chartArea6.AxisY.Title = "Turbidity [NTU]";
            chartArea6.Name = "ChartArea1";
            this.chartTwo.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTwo.Legends.Add(legend6);
            this.chartTwo.Location = new System.Drawing.Point(593, 3);
            this.chartTwo.Name = "chartTwo";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.MarkerBorderWidth = 2;
            series6.Name = "Series1";
            this.chartTwo.Series.Add(series6);
            this.chartTwo.Size = new System.Drawing.Size(584, 198);
            this.chartTwo.TabIndex = 1;
            this.chartTwo.Text = "chart2";
            // 
            // chartThree
            // 
            this.chartThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.AxisX.Title = "Temperature [C]";
            chartArea7.AxisY.Title = "Turbidity [NTU]";
            chartArea7.Name = "ChartArea1";
            this.chartThree.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartThree.Legends.Add(legend7);
            this.chartThree.Location = new System.Drawing.Point(3, 207);
            this.chartThree.Name = "chartThree";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartThree.Series.Add(series7);
            this.chartThree.Size = new System.Drawing.Size(584, 199);
            this.chartThree.TabIndex = 2;
            this.chartThree.Text = "chart3";
            // 
            // chartFour
            // 
            this.chartFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.AxisX.Title = "Temperature [C]";
            chartArea8.AxisY.Title = "Turbidity [NTU]";
            chartArea8.Name = "ChartArea1";
            this.chartFour.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartFour.Legends.Add(legend8);
            this.chartFour.Location = new System.Drawing.Point(593, 207);
            this.chartFour.Name = "chartFour";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartFour.Series.Add(series8);
            this.chartFour.Size = new System.Drawing.Size(584, 199);
            this.chartFour.TabIndex = 3;
            this.chartFour.Text = "chart4";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 41);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(121, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(139, 41);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(126, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1180, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperature 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turbidity 1";
            // 
            // tempOneVal
            // 
            this.tempOneVal.AutoSize = true;
            this.tempOneVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOneVal.Location = new System.Drawing.Point(424, 37);
            this.tempOneVal.Name = "tempOneVal";
            this.tempOneVal.Size = new System.Drawing.Size(27, 12);
            this.tempOneVal.TabIndex = 7;
            this.tempOneVal.Text = "0 °C";
            // 
            // turbOneVal
            // 
            this.turbOneVal.AutoSize = true;
            this.turbOneVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turbOneVal.Location = new System.Drawing.Point(424, 54);
            this.turbOneVal.Name = "turbOneVal";
            this.turbOneVal.Size = new System.Drawing.Size(38, 12);
            this.turbOneVal.TabIndex = 8;
            this.turbOneVal.Text = "0 NTU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperature 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Turbidity 2";
            // 
            // tempTwoVal
            // 
            this.tempTwoVal.AutoSize = true;
            this.tempTwoVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTwoVal.Location = new System.Drawing.Point(623, 37);
            this.tempTwoVal.Name = "tempTwoVal";
            this.tempTwoVal.Size = new System.Drawing.Size(27, 12);
            this.tempTwoVal.TabIndex = 11;
            this.tempTwoVal.Text = "0 °C";
            // 
            // turbTwoVal
            // 
            this.turbTwoVal.AutoSize = true;
            this.turbTwoVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turbTwoVal.Location = new System.Drawing.Point(623, 53);
            this.turbTwoVal.Name = "turbTwoVal";
            this.turbTwoVal.Size = new System.Drawing.Size(38, 12);
            this.turbTwoVal.TabIndex = 12;
            this.turbTwoVal.Text = "0 NTU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(700, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "Temperature 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "Turbidity 3";
            // 
            // tempThreeVal
            // 
            this.tempThreeVal.AutoSize = true;
            this.tempThreeVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempThreeVal.Location = new System.Drawing.Point(794, 37);
            this.tempThreeVal.Name = "tempThreeVal";
            this.tempThreeVal.Size = new System.Drawing.Size(27, 12);
            this.tempThreeVal.TabIndex = 15;
            this.tempThreeVal.Text = "0 °C";
            // 
            // turbThreeVal
            // 
            this.turbThreeVal.AutoSize = true;
            this.turbThreeVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turbThreeVal.Location = new System.Drawing.Point(794, 52);
            this.turbThreeVal.Name = "turbThreeVal";
            this.turbThreeVal.Size = new System.Drawing.Size(38, 12);
            this.turbThreeVal.TabIndex = 16;
            this.turbThreeVal.Text = "0 NTU";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(867, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 12);
            this.label13.TabIndex = 17;
            this.label13.Text = "Temperature 4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(891, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "Turbidity 4";
            // 
            // tempFourVal
            // 
            this.tempFourVal.AutoSize = true;
            this.tempFourVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFourVal.Location = new System.Drawing.Point(961, 37);
            this.tempFourVal.Name = "tempFourVal";
            this.tempFourVal.Size = new System.Drawing.Size(27, 12);
            this.tempFourVal.TabIndex = 19;
            this.tempFourVal.Text = "0 °C";
            // 
            // turbFourVal
            // 
            this.turbFourVal.AutoSize = true;
            this.turbFourVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turbFourVal.Location = new System.Drawing.Point(961, 54);
            this.turbFourVal.Name = "turbFourVal";
            this.turbFourVal.Size = new System.Drawing.Size(38, 12);
            this.turbFourVal.TabIndex = 20;
            this.turbFourVal.Text = "0 NTU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 500);
            this.Controls.Add(this.turbFourVal);
            this.Controls.Add(this.tempFourVal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.turbThreeVal);
            this.Controls.Add(this.tempThreeVal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.turbTwoVal);
            this.Controls.Add(this.tempTwoVal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.turbOneVal);
            this.Controls.Add(this.tempOneVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Temperature Turbidity Data Logger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFour)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTwo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThree;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFour;
        private System.Windows.Forms.ToolStripMenuItem calibrationToolStripMenuItem;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempOneVal;
        private System.Windows.Forms.Label turbOneVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tempTwoVal;
        private System.Windows.Forms.Label turbTwoVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tempThreeVal;
        private System.Windows.Forms.Label turbThreeVal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label tempFourVal;
        private System.Windows.Forms.Label turbFourVal;
        private System.Windows.Forms.ToolStripMenuItem generateGraphToolStripMenuItem;
    }
}

