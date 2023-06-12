using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventorySytem_GUI
{
    public partial class ReportPage : UserControl
    {

        public ReportPage()
        {
            InitializeComponent();
            // Generate the chart data and populate the chart
            GenerateChart();
        }

        private void GenerateChart()
        {
            // Add sample data points to the chart
            chart1.Series.Add("Sales");
            chart1.Series["Sales"].ChartType = SeriesChartType.Line;
            chart1.Series["Sales"].Points.AddXY("Jan", 50);
            chart1.Series["Sales"].Points.AddXY("Feb", 70);
            chart1.Series["Sales"].Points.AddXY("Mar", 65);
            chart1.Series["Sales"].Points.AddXY("Apr", 80);
            chart1.Series["Sales"].Points.AddXY("May", 90);
            chart1.Series["Sales"].Points.AddXY("Jun", 75);
            chart1.Series["Sales"].Points.AddXY("Jul", 85);
            chart1.Series["Sales"].Points.AddXY("Aug", 60);
            chart1.Series["Sales"].Points.AddXY("Sep", 95);
            chart1.Series["Sales"].Points.AddXY("Oct", 80);
            chart1.Series["Sales"].Points.AddXY("Nov", 70);
            chart1.Series["Sales"].Points.AddXY("Dec", 90);

            // Set chart title and axis labels
            chart1.Titles.Add("Monthly Sales");
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Sales";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeReportButton_Click(object sender, EventArgs e)
        {
            // verify the user wants to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
