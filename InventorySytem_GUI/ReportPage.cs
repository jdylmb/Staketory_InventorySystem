using StakeTory_InventorySystem;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventorySytem_GUI
{
    public partial class ReportPage : UserControl
    {
        private SalesManagement salesManagement;

        public ReportPage()
        {
            salesManagement = new SalesManagement("sales.json");
            InitializeComponent();
            // Generate the chart data and populate the chart
            GenerateChart();
        }

        private void GenerateChart()
        {
            // Add sample data points to the chart
            SalesData[] salesDataArray = this.salesManagement.CalculateTotalSalesPerMonth();

            monthlySales.Series.Add("Sales");
            monthlySales.Series["Sales"].ChartType = SeriesChartType.Line;
            foreach (SalesData data in salesDataArray)
            {
                string month = data.Month;
                double totalSales = data.TotalSales;
                monthlySales.Series["Sales"].Points.AddXY(month, totalSales);
                Console.WriteLine($"Month: {month}, Total Sales: {totalSales}");
            }

            // Set chart title and axis labels
            monthlySales.ChartAreas[0].AxisX.Title = "Month";
            monthlySales.ChartAreas[0].AxisY.Title = "Sales";

            salesDataArray = this.salesManagement.GenerateWeeklySalesReport();

            weeklySalesChart.Series.Add("Sales");
            weeklySalesChart.Series["Sales"].ChartType = SeriesChartType.Line;
            foreach (SalesData data in salesDataArray)
            {
                string month = data.Month;
                double totalSales = data.TotalSales;
                weeklySalesChart.Series["Sales"].Points.AddXY(month, totalSales);
                Console.WriteLine($"Month: {month}, Total Sales: {totalSales}");
            }
            

            // Set chart title and axis labels
            weeklySalesChart.ChartAreas[0].AxisX.Title = "Week";
            weeklySalesChart.ChartAreas[0].AxisY.Title = "Sales";

            DateTime currentDateTime = DateTime.Now;
            string currentMonthYear = currentDateTime.ToString("yyyy-MM");

            Product topProduct = this.salesManagement.GetHighestSellingProductOfMonth(currentMonthYear);
            label1.Text += " " + topProduct.Name;
            topSalesAmount.Text += topProduct.Price.ToString("0.00");

            double calculatedTotalSales = this.salesManagement.CalculateTotalSales();

            totalSales.Text += calculatedTotalSales.ToString("0.00");
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

        private void weeklySales_Click(object sender, EventArgs e)
        {

        }

        private void monthlySales_Click(object sender, EventArgs e)
        {

        }

        private void week_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReportPage_Load(object sender, EventArgs e)
        {

        }

        private void ReportPage_Load_1(object sender, EventArgs e)
        {

        }

        private void customizedPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void totalSales_Click(object sender, EventArgs e)
        {

        }
    }
}
