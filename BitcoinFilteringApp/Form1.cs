using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace BitcoinFilteringApp
{
    public partial class Form1 : Form
    {
        // Constant variables
        private const string fileName = "btc.csv";
        private const int dateColumnIndex = 0;
        private const int highColumnIndex = 2;
        private const int lowColumnIndex = 3;
        private const int volumeColumnIndex = 6;
        private const double conversionRate = 0.87;
        private const int volumeDivider = 1000000;

        // Class variables
        private IEnumerable<string> dataSubset;
        private DateTime maxDate;
        private DateTime minDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadAndFilterFileData();

            SetTBValues();

            ChartConfiguration();    
        }

        /***
         * Reads the source file and converts the data to euros. 
        */
        private void ReadAndFilterFileData()
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                // Skips the header row.
                lines = lines.Skip(1).ToArray();

                maxDate = lines.Select(l => DateTime.Parse(l.Split(',')[dateColumnIndex])).Max();
                // Narrow down the data subset to 365 days.
                minDate = maxDate.AddYears(-1).AddDays(1);

                IList<string> dataSubsetList = lines.Where(l => DateTime.Parse(l.Split(',')[dateColumnIndex]) >= minDate).ToList<string>();

                for (int i = 0; i < dataSubsetList.Count; i++)
                {
                    string[] listRecord = dataSubsetList[i].Split(',');
                    listRecord[lowColumnIndex] = (Convert.ToDouble(listRecord[lowColumnIndex].Replace('.', ',')) * conversionRate).ToString();
                    listRecord[highColumnIndex] = (Convert.ToDouble(listRecord[highColumnIndex].Replace('.', ',')) * conversionRate).ToString();
                    listRecord[volumeColumnIndex] = (Convert.ToInt64(listRecord[volumeColumnIndex])).ToString();
                    dataSubsetList[i] = string.Join(";",listRecord);
                }

                dataSubset = dataSubsetList;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /***
         * Sets the label values in the form.
        */
        private void SetTBValues()
        {
            try
            {
                lowMaxTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[lowColumnIndex])).Max(), 2).ToString();
                lowMinTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[lowColumnIndex])).Min(), 2).ToString();
                lowMeanTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[lowColumnIndex])).Average(), 2).ToString();

                highMaxTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[highColumnIndex])).Max(), 2).ToString();
                highMinTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[highColumnIndex])).Min(), 2).ToString();
                highMeanTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[highColumnIndex])).Average(), 2).ToString();

                volumeMaxTB.Text = dataSubset.Select(l => Int64.Parse(l.Split(';')[volumeColumnIndex]) / volumeDivider).Max().ToString();
                volumeMinTB.Text = dataSubset.Select(l => Int64.Parse(l.Split(';')[volumeColumnIndex]) / volumeDivider).Min().ToString();
                volumeMeanTB.Text = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[volumeColumnIndex]) / volumeDivider).Average(), 2).ToString();

                dateLabel.Text = minDate.Year.ToString() + "-" + minDate.Month.ToString() + " - " + maxDate.Year.ToString() + "-" + maxDate.Month.ToString();
            }
            catch (Exception e)
            {
                throw ;
            }
        }
        
        /***
         * Sets line chart settings and populates the series.
        */
        private void ChartConfiguration()
        {
            try
            {
                // Bitcoin low series settings
                bitcoinChart.Series.Clear();
                bitcoinChart.Series.Add(new Series("Bitcoin Low"));
                bitcoinChart.Series[0].XValueType = ChartValueType.Date;
                bitcoinChart.Series[0].ChartType = SeriesChartType.Line;
                bitcoinChart.Series[0].BorderWidth = 3;
                bitcoinChart.Series[0].Color = Color.Red;

                // Bitcoin high series settings
                bitcoinChart.Series.Add(new Series("Bitcoin High"));
                bitcoinChart.Series[1].ChartType = SeriesChartType.Line;
                bitcoinChart.Series[1].BorderWidth = 3;
                bitcoinChart.Series[1].Color = Color.Green;

                //Chart area settings
                bitcoinChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                bitcoinChart.ChartAreas[0].AxisX.Interval = 1;
                bitcoinChart.ChartAreas[0].AxisX.IntervalOffset = -1;
                bitcoinChart.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                // Add one month for better readability
                bitcoinChart.ChartAreas[0].AxisX.Maximum = maxDate.AddMonths(1).ToOADate();
                bitcoinChart.ChartAreas[0].AxisX.Title = "Date";

                bitcoinChart.ChartAreas[0].AxisY.RoundAxisValues();
                bitcoinChart.ChartAreas[0].AxisY.IsStartedFromZero = false;
                bitcoinChart.ChartAreas[0].AxisY.Minimum = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[lowColumnIndex])).Min());
                bitcoinChart.ChartAreas[0].AxisY.Maximum = Math.Round(dataSubset.Select(l => Double.Parse(l.Split(';')[highColumnIndex])).Max());
                bitcoinChart.ChartAreas[0].AxisY.Interval = 1000;

                // Sets each month value for the chart
                DateTime currentDt = minDate;
                while (currentDt <= maxDate)
                {
                    var dataSubsetPIT = dataSubset.Where(l => DateTime.Parse(l.Split(';')[dateColumnIndex]) == currentDt);
                    var lowValuePIT = dataSubsetPIT.Select(line => Double.Parse(line.Split(';')[lowColumnIndex])).First();
                    var highValuePIT = dataSubsetPIT.Select(line => Double.Parse(line.Split(';')[highColumnIndex])).First();

                    bitcoinChart.Series[1].Points.AddXY(currentDt.Date, highValuePIT);
                    bitcoinChart.Series[0].Points.AddXY(currentDt.Date, lowValuePIT);

                    currentDt = currentDt.AddMonths(1);
                    // Makes sure the first and last date will be included.
                    if (currentDt.Day != maxDate.Day)
                    {
                        currentDt = currentDt.AddDays(-1);
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /***
         * Saves the chart as a .jpeg image and filtered and converted data into a .csv file to current directory.
        */
        private void saveFilesBtn_Click(object sender, EventArgs e)
        {
            string directoryPath = Environment.CurrentDirectory;
            string dateSuffix = minDate.Year.ToString() + "-" + minDate.Month.ToString() + "_" + maxDate.Year.ToString() + "-" + maxDate.Month.ToString();
            string pathImage = directoryPath + "//bitcoinchart_" + dateSuffix + ".jpeg";
            string filterFileName = "//bitcoindata_" + dateSuffix + ".csv";

            try
            {
                bitcoinChart.SaveImage(pathImage, ChartImageFormat.Jpeg);

                using (StreamWriter file = new StreamWriter(directoryPath + filterFileName))
                {
                    file.WriteLine("Date;Volume;Low (EUR);High (EUR)");
                    foreach (var dataRecord in dataSubset)
                    {
                        string[] recordArray = dataRecord.Split(';');
                        file.WriteLine(recordArray[dateColumnIndex] + ";" + recordArray[volumeColumnIndex] + ";" + recordArray[lowColumnIndex] + ";" + recordArray[highColumnIndex]);
                    }
                }
                MessageBox.Show("Chart and csv file are saved to " + directoryPath);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
