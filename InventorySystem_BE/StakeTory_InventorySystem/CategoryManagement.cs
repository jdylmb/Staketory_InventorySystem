using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeTory_InventorySystem
{
    public class CategoryManagement
    {
        private List<Category> categories;
        private string categoriesFilePath;

        public CategoryManagement(string categoriesFilePath) 
        {
            this.categoriesFilePath = categoriesFilePath;
            LoadCategories();
        }

        private void LoadCategories()
        {
            if (File.Exists(this.categoriesFilePath))
            {
                string json = File.ReadAllText(this.categoriesFilePath);
                categories = JsonConvert.DeserializeObject<List<Category>>(json);
            }
            else
            {
                categories = new List<Category>();
            }
        }
    }
}
