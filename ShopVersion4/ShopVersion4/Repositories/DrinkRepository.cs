using ShopVersion4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVersion4.Repositories
{
    internal class DrinkRepository
    {
        private CsvService Service = new CsvService();
        public static List<Drink> Drinks { get; set; }

        public DrinkRepository()
        {
            Drinks = Service.ReadDrinks();
        }
    }
}
