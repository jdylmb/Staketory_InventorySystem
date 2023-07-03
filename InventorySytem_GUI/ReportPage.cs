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
            //GenerateChart();
        }

        private void GenerateChart()
        {
            // Add sample data points to the chart
            SalesData[] salesDataArray = this.salesManagement.CalculateTotalSalesPerMonth();

            monthlySales.Series.Clear();
            weeklySalesChart.Series.Clear();

            monthlySales.Series.Add("Monthly Sales");
            monthlySales.Series["Monthly Sales"].ChartType = SeriesChartType.Line;
            foreach (SalesData data in salesDataArray)
            {
                string month = data.Month;
                double totalSales = data.TotalSales;
                monthlySales.Series["Monthly Sales"].Points.AddXY(month, totalSales);
                Console.WriteLine($"Month: {month}, Total Sales: {totalSales}");
            }

            // Set chart title and axis labels
            monthlySales.ChartAreas[0].AxisX.Title = "Month";
            monthlySales.ChartAreas[0].AxisY.Title = "Sales";

            salesDataArray = this.salesManagement.GenerateWeeklySalesReport();

            weeklySalesChart.Series.Add("Weekly Sales");
            weeklySalesChart.Series["Weekly Sales"].ChartType = SeriesChartType.Line;
            foreach (SalesData data in salesDataArray)
            {
                string month = data.Month;
                double totalSales = data.TotalSales;
                weeklySalesChart.Series["Weekly Sales"].Points.AddXY(month, totalSales);
                Console.WriteLine($"Month: {month}, Total Sales: {totalSales}");
            }


            // Set chart title and axis labels
            weeklySalesChart.ChartAreas[0].AxisX.Title = "Week";
            weeklySalesChart.ChartAreas[0].AxisY.Title = "Sales";

            DateTime currentDateTime = DateTime.Now;
            string currentMonthYear = currentDateTime.ToString("yyyy-MM");

            Product topProduct = this.salesManagement.GetHighestSellingProductOfMonth(currentMonthYear);

            if (topProduct != null)
            {
                label1.Text = "Top Product: " + topProduct.Name;
                topSalesAmount.Text = "P " + topProduct.Price.ToString("0.00");
            }
            else
            {
                label1.Text = "Top Product: No Data Yet";
                topSalesAmount.Text = "No value yet.";
            }

            double calculatedTotalSales = this.salesManagement.CalculateTotalSales();

            totalSales.Text = "P " + calculatedTotalSales.ToString("0.00");
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
            //GenerateChart();
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

        private void MngProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void MngProductPanel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ReportPage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                salesManagement = new SalesManagement("sales.json");
                // User control is being shown, perform reloading logic here
                GenerateChart();
            }
        }

        private void weeklySalesChart_Click(object sender, EventArgs e)
        {

        }
    }
}
