using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeTory_InventorySystem
{
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
    }
}
    