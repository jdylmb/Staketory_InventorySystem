using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeTory_InventorySystem
{
    public class ProductManagement
    {
        private List<Product> inventory;
        private string inventoryFilePath;

        public ProductManagement(string inventoryFilePath)
        {
            this.inventoryFilePath = inventoryFilePath;
            LoadInventory();
        }

        private void LoadInventory()
        {
            if (File.Exists(this.inventoryFilePath))
            {
                string json = File.ReadAllText(this.inventoryFilePath);
                inventory = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                inventory = new List<Product>();
            }
        }

        public List<Product> GetProducts()
        {
            return inventory;
        }
        private void SaveInventory()
        {
            string json = JsonConvert.SerializeObject(inventory);
            File.WriteAllText(inventoryFilePath, json);
        }

        // Rest of the methods (AddItem, DisplayItems, UpdateQuantity, DisplayItem

        public bool AddItem(Product product)
        {
            if (inventory.Exists(item => item.Code.Equals(product.Code, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            inventory.Add(product);
            SaveInventory();

            return true;
        }

        public void DisplayItems()
        {
            Console.WriteLine("Inventory Items:");
            Console.WriteLine("----------------");

            foreach (var item in inventory)
            {
                Console.WriteLine($"Code: {item.Code}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Quantity: {item.Quantity}");
                Console.WriteLine($"Price: ${item.Price}");
                Console.WriteLine("----------------");
            }
        }

        public void UpdateQuantity(string code, int quantity)
        {
            Product item = FindItem(code);

            if (item != null)
            {
                item.Quantity = quantity;
                SaveInventory();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void DisplayItem(string code)
        {
            Product item = FindItem(code);

            if (item != null)
            {
                Console.WriteLine($"Code: {item.Code}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Quantity: {item.Quantity}");
                Console.WriteLine($"Price: ${item.Price}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public Product FindItem(string code)
        {
            return inventory.Find(item => item.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        public void DeleteItem(string code)
        {
            Product productToRemove = inventory.Find(item => item.Code.Equals(code, StringComparison.OrdinalIgnoreCase));

            if (productToRemove != null)
            {
                inventory.Remove(productToRemove);
            }

            SaveInventory();
        }

        public void UpdateProduct(Product product)
        {
            int selectedIndex = inventory.FindIndex(item => item.Code.Equals(product.Code, StringComparison.OrdinalIgnoreCase));

            if (selectedIndex >= 0 && selectedIndex < inventory.Count)
            {
                inventory[selectedIndex] = product;
            }

            SaveInventory();
        }
    }
}
    