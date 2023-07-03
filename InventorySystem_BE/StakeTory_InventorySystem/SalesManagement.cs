using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeTory_InventorySystem
{
    public class SalesData
    {
        public string Month { get; set; }
        public double TotalSales { get; set; }
    }

    public class SalesManagement
    {
        public List<Sales> sales;
        private string inventoryFilePath;

        public SalesManagement(string inventoryFilePath)
        {
            this.inventoryFilePath = inventoryFilePath;
            LoadInventory();
        }

        private void LoadInventory()
        {
            if (File.Exists(this.inventoryFilePath))
            {
                string json = File.ReadAllText(this.inventoryFilePath);
                sales = JsonConvert.DeserializeObject<List<Sales>>(json);
            }
            else
            {
                sales = new List<Sales>();
            }
        }
      
        private void save()
        {
            string json = JsonConvert.SerializeObject(sales);
            File.WriteAllText(inventoryFilePath, json);
        }

        // Rest of the methods (AddItem, DisplayItems, UpdateQuantity, DisplayItem

        public bool AddItem(Sales sale)
        {

            sales.Add(sale);
            save();

            return true;
        }

        public SalesData[] CalculateTotalSalesPerMonth()
        {
            Dictionary<string, double> salesPerMonth = new Dictionary<string, double>();

            foreach (Sales sale in sales)
            {
                DateTime saleDate = DateTime.ParseExact(sale.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string monthYear = saleDate.ToString("yyyy-MM");

                if (salesPerMonth.ContainsKey(monthYear))
                {
                    salesPerMonth[monthYear] += sale.Amount;
                }
                else
                {
                    salesPerMonth[monthYear] = sale.Amount;
                }
            }

            // Convert the dictionary to an array of SalesData objects
            SalesData[] salesDataArray = salesPerMonth.Select(kv => new SalesData { Month = kv.Key, TotalSales = kv.Value }).ToArray();

            return salesDataArray;
        }

        public Product GetHighestSellingProductOfMonth(string monthYear)
        {
            double highestSales = 0;
            Product highestProduct = null;

            ProductManagement productManagement = new ProductManagement("product.json");

            if(sales == null || sales?.Count == 0) {
                return null;
            }

            foreach (Sales sale in sales)
            {
                DateTime saleDate = DateTime.ParseExact(sale.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string saleMonthYear = saleDate.ToString("yyyy-MM");

                if (saleMonthYear == monthYear && sale.Amount > highestSales)
                {
                    highestSales = sale.Amount;
                    highestProduct = productManagement.FindItem(sale.Product_Code);
                }
            }

            if (highestProduct == null) {
                return null;
            }

            highestProduct.Price = highestSales;
            return highestProduct;
        }


        public SalesData[] GenerateWeeklySalesReport()
        {
            Dictionary<string, double> weeklySalesReport = new Dictionary<string, double>();

            foreach (Sales sale in sales)
            {
                DateTime saleDate = DateTime.ParseExact(sale.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string weekNumber = GetWeekNumber(saleDate);

                if (weeklySalesReport.ContainsKey(weekNumber))
                {
                    weeklySalesReport[weekNumber] += sale.Amount;
                }
                else
                {
                    weeklySalesReport[weekNumber] = sale.Amount;
                }
            }

            // Convert the dictionary to an array of SalesData objects
            SalesData[] salesDataArray = weeklySalesReport.Select(kv => new SalesData { Month = kv.Key, TotalSales = kv.Value }).ToArray();

            return salesDataArray;
        }

        private string GetWeekNumber(DateTime date)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            int weekNumber = cal.GetWeekOfYear(date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);

            return $"{date.Year}-W{weekNumber.ToString("D2")}";
        }

        public double CalculateTotalSales()
        {
            double totalSales = 0;

            foreach (Sales sale in sales)
            {
                totalSales += sale.Amount;
            }

            return totalSales;
        }

    }
}
    