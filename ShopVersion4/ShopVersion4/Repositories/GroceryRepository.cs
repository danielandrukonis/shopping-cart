using ShopVersion4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVersion4.Repositories
{
    internal class GroceryRepository
    {
        private CsvService Service = new CsvService();
        public static List<Grocery> Groceries { get; set; }

        public GroceryRepository()
        {
            Groceries = Service.ReadGroceries();
        }
    }
}
