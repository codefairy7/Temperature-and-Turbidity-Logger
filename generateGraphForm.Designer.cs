namespace TTGrapher
{
    partial class generateGraphForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generateGraphForm));
            this.label1 = new System.Windows.Forms.Label();
            this.filepathTxtBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.generateGraphBtn = new System.Windows.Forms.Button();
            this.saveGraphBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File";
            // 
            // filepathTxtBox
            // 
            this.filepathTxtBox.Location = new System.Drawing.Point(92, 21);
            this.filepathTxtBox.Name = "filepathTxtBox";
            this.filepathTxtBox.Size = new System.Drawing.Size(417, 20);
            this.filepathTxtBox.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(515, 19);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(125, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // generateGraphBtn
            // 
            this.generateGraphBtn.Location = new System.Drawing.Point(369, 58);
            this.generateGraphBtn.Name = "generateGraphBtn";
            this.generateGraphBtn.Size = new System.Drawing.Size(140, 23);
            this.generateGraphBtn.TabIndex = 3;
            this.generateGraphBtn.Text = "Generate Graph";
            this.generateGraphBtn.UseVisualStyleBackColor = true;
            this.generateGraphBtn.Click += new System.EventHandler(this.generateGraphBtn_Click);
            // 
            // saveGraphBtn
            // 
            this.saveGraphBtn.Location = new System.Drawing.Point(515, 58);
            this.saveGraphBtn.Name = "saveGraphBtn";
            this.saveGraphBtn.Size = new System.Drawing.Size(125, 23);
            this.saveGraphBtn.TabIndex = 4;
            this.saveGraphBtn.Text = "Save Graph";
            this.saveGraphBtn.UseVisualStyleBackColor = true;
            this.saveGraphBtn.Click += new System.EventHandler(this.saveGraphBtn_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 92);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(922, 414);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // generateGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 518);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.saveGraphBtn);
            this.Controls.Add(this.generateGraphBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.filepathTxtBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "generateGraphForm";
            this.Text = "Generate Graph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepathTxtBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button generateGraphBtn;
        private System.Windows.Forms.Button saveGraphBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}