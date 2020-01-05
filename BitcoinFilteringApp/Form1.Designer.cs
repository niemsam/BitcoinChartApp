namespace BitcoinFilteringApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bitcoinChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lowMinTB = new System.Windows.Forms.TextBox();
            this.lowMaxTB = new System.Windows.Forms.TextBox();
            this.lowMeanTB = new System.Windows.Forms.TextBox();
            this.highMeanTB = new System.Windows.Forms.TextBox();
            this.highMaxTB = new System.Windows.Forms.TextBox();
            this.highMinTB = new System.Windows.Forms.TextBox();
            this.volumeMeanTB = new System.Windows.Forms.TextBox();
            this.volumeMaxTB = new System.Windows.Forms.TextBox();
            this.volumeMinTB = new System.Windows.Forms.TextBox();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.saveFilesBtn = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitcoinChart)).BeginInit();
            this.SuspendLayout();
            // 
            // bitcoinChart
            // 
            chartArea1.Name = "ChartArea1";
            this.bitcoinChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bitcoinChart.Legends.Add(legend1);
            this.bitcoinChart.Location = new System.Drawing.Point(18, 334);
            this.bitcoinChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bitcoinChart.Name = "bitcoinChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.bitcoinChart.Series.Add(series1);
            this.bitcoinChart.Size = new System.Drawing.Size(1654, 574);
            this.bitcoinChart.TabIndex = 0;
            this.bitcoinChart.Text = "bitcoinChart";
            // 
            // lowMinTB
            // 
            this.lowMinTB.Location = new System.Drawing.Point(198, 102);
            this.lowMinTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowMinTB.Name = "lowMinTB";
            this.lowMinTB.Size = new System.Drawing.Size(148, 26);
            this.lowMinTB.TabIndex = 1;
            // 
            // lowMaxTB
            // 
            this.lowMaxTB.Location = new System.Drawing.Point(394, 102);
            this.lowMaxTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowMaxTB.Name = "lowMaxTB";
            this.lowMaxTB.Size = new System.Drawing.Size(148, 26);
            this.lowMaxTB.TabIndex = 2;
            // 
            // lowMeanTB
            // 
            this.lowMeanTB.Location = new System.Drawing.Point(582, 102);
            this.lowMeanTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowMeanTB.Name = "lowMeanTB";
            this.lowMeanTB.Size = new System.Drawing.Size(148, 26);
            this.lowMeanTB.TabIndex = 3;
            // 
            // highMeanTB
            // 
            this.highMeanTB.Location = new System.Drawing.Point(582, 166);
            this.highMeanTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highMeanTB.Name = "highMeanTB";
            this.highMeanTB.Size = new System.Drawing.Size(148, 26);
            this.highMeanTB.TabIndex = 6;
            // 
            // highMaxTB
            // 
            this.highMaxTB.Location = new System.Drawing.Point(394, 166);
            this.highMaxTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highMaxTB.Name = "highMaxTB";
            this.highMaxTB.Size = new System.Drawing.Size(148, 26);
            this.highMaxTB.TabIndex = 5;
            // 
            // highMinTB
            // 
            this.highMinTB.Location = new System.Drawing.Point(198, 166);
            this.highMinTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highMinTB.Name = "highMinTB";
            this.highMinTB.Size = new System.Drawing.Size(148, 26);
            this.highMinTB.TabIndex = 4;
            // 
            // volumeMeanTB
            // 
            this.volumeMeanTB.Location = new System.Drawing.Point(582, 232);
            this.volumeMeanTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeMeanTB.Name = "volumeMeanTB";
            this.volumeMeanTB.Size = new System.Drawing.Size(148, 26);
            this.volumeMeanTB.TabIndex = 9;
            // 
            // volumeMaxTB
            // 
            this.volumeMaxTB.Location = new System.Drawing.Point(394, 232);
            this.volumeMaxTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeMaxTB.Name = "volumeMaxTB";
            this.volumeMaxTB.Size = new System.Drawing.Size(148, 26);
            this.volumeMaxTB.TabIndex = 8;
            // 
            // volumeMinTB
            // 
            this.volumeMinTB.Location = new System.Drawing.Point(198, 232);
            this.volumeMinTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeMinTB.Name = "volumeMinTB";
            this.volumeMinTB.Size = new System.Drawing.Size(148, 26);
            this.volumeMinTB.TabIndex = 7;
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.Location = new System.Drawing.Point(32, 103);
            this.lowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(107, 25);
            this.lowLabel.TabIndex = 10;
            this.lowLabel.Text = "Low (EUR)";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.Location = new System.Drawing.Point(32, 168);
            this.highLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(111, 25);
            this.highLabel.TabIndex = 11;
            this.highLabel.Text = "High (EUR)";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(18, 234);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(149, 25);
            this.volumeLabel.TabIndex = 12;
            this.volumeLabel.Text = "Volume (Billion)";
            // 
            // saveFilesBtn
            // 
            this.saveFilesBtn.Location = new System.Drawing.Point(1442, 79);
            this.saveFilesBtn.Name = "saveFilesBtn";
            this.saveFilesBtn.Size = new System.Drawing.Size(167, 35);
            this.saveFilesBtn.TabIndex = 13;
            this.saveFilesBtn.Text = "Save file and image";
            this.saveFilesBtn.UseVisualStyleBackColor = true;
            this.saveFilesBtn.Click += new System.EventHandler(this.saveFilesBtn_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(250, 57);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(44, 25);
            this.minLabel.TabIndex = 14;
            this.minLabel.Text = "Min";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLabel.Location = new System.Drawing.Point(622, 57);
            this.meanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(62, 25);
            this.meanLabel.TabIndex = 15;
            this.meanLabel.Text = "Mean";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(443, 57);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(50, 25);
            this.maxLabel.TabIndex = 16;
            this.maxLabel.Text = "Max";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(1020, 57);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 25);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 922);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.saveFilesBtn);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.volumeMeanTB);
            this.Controls.Add(this.volumeMaxTB);
            this.Controls.Add(this.volumeMinTB);
            this.Controls.Add(this.highMeanTB);
            this.Controls.Add(this.highMaxTB);
            this.Controls.Add(this.highMinTB);
            this.Controls.Add(this.lowMeanTB);
            this.Controls.Add(this.lowMaxTB);
            this.Controls.Add(this.lowMinTB);
            this.Controls.Add(this.bitcoinChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitcoinChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart bitcoinChart;
        private System.Windows.Forms.TextBox lowMinTB;
        private System.Windows.Forms.TextBox lowMaxTB;
        private System.Windows.Forms.TextBox lowMeanTB;
        private System.Windows.Forms.TextBox highMeanTB;
        private System.Windows.Forms.TextBox highMaxTB;
        private System.Windows.Forms.TextBox highMinTB;
        private System.Windows.Forms.TextBox volumeMeanTB;
        private System.Windows.Forms.TextBox volumeMaxTB;
        private System.Windows.Forms.TextBox volumeMinTB;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Button saveFilesBtn;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

