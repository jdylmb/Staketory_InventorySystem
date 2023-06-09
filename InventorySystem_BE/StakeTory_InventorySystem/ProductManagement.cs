﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeTory_InventorySystem
{
    public class ProductManagement
    {
        public List<Product> inventory;
        private string inventoryFilePath;
        SalesManagement salesManagement;

        public ProductManagement(string inventoryFilePath)
        {
            this.inventoryFilePath = inventoryFilePath;
            LoadInventory();
            salesManagement = new SalesManagement("sales.json");
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

        public List<Product> FilterItems(string searchString)
        {
            searchString = searchString.ToLower();
            return inventory.FindAll(item =>
                item.Code.ToLower().Contains(searchString) ||
                item.Name.ToLower().Contains(searchString));


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

        public void UpdateProduct(Product product, int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < inventory.Count)
            {
                if (inventory[selectedIndex].Quantity > product.Quantity)
                {
                    double totalSales = inventory[selectedIndex].TotalSales + (inventory[selectedIndex].Quantity - product.Quantity) * inventory[selectedIndex].Price;

                    product.TotalSales = totalSales;

                    Sales item = new Sales
                    {
                        Product_Code = product.Code,
                        Amount = totalSales,
                        Date = DateTime.Now.ToString("yyyy-MM-dd")
                    };
                    salesManagement.AddItem(item);
                }
                inventory[selectedIndex] = product;
            }

            SaveInventory();
        }
    }
}
    