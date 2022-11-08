namespace ShopVersion4.Entities
{
    internal class ShoppingCart
    {
        private static List<Product> Products = new();
        

        public static void AddProduct(Product product)
        {
            Products.Add(product);

        }

        public static void PrintCart()

        {
            foreach (var product in Products)
            {

                Console.WriteLine("Your shopping cart list: " + product);

            }
                      
        }
        private static List<Product> Cost = new();
        public static void TotalCost(Product Price)
        {

            Cost.Add(Price);
        }

        public static void PrintCost()
        {
            double shoppingCartSum = 0;
            foreach (var price in Products)
            {
                shoppingCartSum = shoppingCartSum + Convert.ToDouble(price.Price);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Total cost: {shoppingCartSum} eur");
            Console.WriteLine("-------------------------------------------------");

        }


        public static void DeleteCartItems()
        {
            Products.Clear();
        }
    }
 }

