using ShopVersion4.Entities;

namespace ShopVersion4
{
    internal class CsvService
    {
        private string CandiesPath = "C:\\Users\\Ieva\\source\\repos\\ShopVersion4\\ShopVersion4\\Data\\Sweets.csv";
        private string MeatsPath = "C:\\Users\\Ieva\\source\\repos\\ShopVersion4\\ShopVersion4\\Data\\Meat.csv";
        private string GroceriesPath = "C:\\Users\\Ieva\\source\\repos\\ShopVersion4\\ShopVersion4\\Data\\Groceries.csv";
        private string DrinksPath = "C:\\Users\\Ieva\\source\\repos\\ShopVersion4\\ShopVersion4\\Data\\Drinks.csv";

        public List<Candy> ReadCandies()
        {
            string text = File.ReadAllText(CandiesPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var candies = new List<Candy>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var candy = new Candy
                {
                    ID = Convert.ToString(productDataArray[0]),
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    SugarAmountInGrams = Convert.ToDouble(productDataArray[5]),
                };
                candies.Add(candy);
            }

            return candies;
        }

        public List<Meat> ReadMeats()
        {
            string text = File.ReadAllText(MeatsPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var meats = new List<Meat>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var meat = new Meat
                {
                    ID = Convert.ToString(productDataArray[0]),
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    Protein = Convert.ToDouble(productDataArray[5]),
                  
                };

                meats.Add(meat);
            }

            return meats;
        }


        public List<Drink> ReadDrinks()
        {
            string text = File.ReadAllText(DrinksPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var drinks = new List<Drink>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var drink = new Drink
                {
                    ID = Convert.ToString(productDataArray[0]),
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Liter = Convert.ToDouble(productDataArray[4]),
                  
                };

                drinks.Add(drink);
            }

            return drinks;
        }

        public List<Grocery> ReadGroceries()
        {
            string text = File.ReadAllText(GroceriesPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var groceries = new List<Grocery>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var grocery = new Grocery
                {
                    ID = Convert.ToString(productDataArray[0]),
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    Fiber = Convert.ToDouble(productDataArray[5]),
                  
                };

                groceries.Add(grocery);
            }

            return groceries;
        }
    }
}

