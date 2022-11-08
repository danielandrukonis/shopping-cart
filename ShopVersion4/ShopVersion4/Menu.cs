using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopVersion4.Entities;
using ShopVersion4.Repositories;

namespace ShopVersion4 { 
    internal class Menu
    {
        int moneyValue;
        
        public void InitiateMenu()
        {
            Console.Write("Provide money input: ");
            string money = Console.ReadLine();
            
            bool success = int.TryParse(money, out moneyValue);
            while (!success)
            {
                Console.WriteLine("Invalid input. Try again...");
                Console.Write("Please enter money amount: ");
                money = Console.ReadLine();
                success = int.TryParse(money, out moneyValue);
            }
            Console.WriteLine($"Your money input {moneyValue}");
            Console.Write("Press [enter] to continue...");
            Console.ReadLine();

            bool isAlive = true;
            while (isAlive)
            {
                
                if (moneyValue > 0)
                {
                    Console.WriteLine("1. Candies");
                    Console.WriteLine("2. Meats");
                    Console.WriteLine("3. Drinks");
                    Console.WriteLine("4. Groceries");
                    Console.WriteLine("5. Buy Candies");
                    Console.WriteLine("6. Buy Meats");
                    Console.WriteLine("7. Buy Drinks");
                    Console.WriteLine("8. Buy Groceries");
                    Console.WriteLine("9. Show cart");
                    Console.WriteLine("10. Confirm purchase");
                    Console.WriteLine("11. Exit");
                } else
                {
                    Console.WriteLine("Not enough money to buy new products");
                    Console.WriteLine("1. Candies");
                    Console.WriteLine("2. Meats");
                    Console.WriteLine("3. Drinks");
                    Console.WriteLine("4. Groceries");
                    Console.WriteLine("9. Show cart");
                    Console.WriteLine("10. Confirm purchase");
                    Console.WriteLine("11. Exit");

                }
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:
                        PrintCandies();
                        break;
                    case 2:
                        PrintMeats();
                        break;
                    case 3:
                        PrintDrinks();
                        break;
                    case 4:
                        PrintGrocery();
                        break;
                    case 5:
                        PrintCandies();
                        BuyCandies();
                        break;
                    case 6:
                        PrintMeats();
                        BuyMeat();
                        break;
                    case 7:
                        PrintDrinks();
                        BuyDrinks();
                        break;
                    case 8:
                        PrintGrocery();
                        BuyGroceries();
                        break;
                    case 9:
                        ShoppingCart.PrintCart();
                        ShoppingCart.PrintCost();
                        break;

                    case 10:
                        ConfirmPurchase();
                        break;

                    case 11:
                        Console.WriteLine("Thank you for visiting our shop");
                        System.Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("This is not valid choice");
                        break;
                }
            }
        }

        public void BuyMeat()
        {
            
            var selectedMeat = GetSelection();
            var meat = MeatRepository.Meats[selectedMeat - 1];
            if (meat == null || moneyValue < 0 || meat.Price > moneyValue)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 1} does not exist OR you DO NOT have enough money");
                return;
            } else
            {
                ShoppingCart.AddProduct(meat);
                decimal leftMoney =  moneyValue - meat.Price;
                Console.WriteLine("You have seleceted: " + meat.ToString());
                Console.WriteLine($"You have got {leftMoney}eur left");
                decimal leftMoney1 = leftMoney;
                moneyValue = (int)leftMoney1;
            }
            
        }

        public void BuyCandies()
        {
            var selectedCandy = GetSelection();
            var candy = CandyRepository.Candies[selectedCandy - 1];
            if (candy is null || moneyValue < 0 || candy.Price > moneyValue)
            {
                Console.WriteLine($"Meat with index {selectedCandy - 1} does not exist OR you DO NOT have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddProduct(candy);
                decimal leftMoney = moneyValue - candy.Price;
                Console.WriteLine("You have seleceted: " + candy);
                Console.WriteLine($"You have got {leftMoney}eur left");
                decimal leftMoney1 = leftMoney;
                moneyValue = (int)leftMoney1;
            }

        }

        public void BuyDrinks()
        {
            var selectedDrink = GetSelection();
            var drink = DrinkRepository.Drinks[selectedDrink - 1];
            if (drink is null || moneyValue < 0 || drink.Price > moneyValue)
            {
                Console.WriteLine($"Meat with index {selectedDrink - 1} does not exist OR you DO NOT have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddProduct(drink);
                decimal leftMoney = moneyValue - drink.Price;
                Console.WriteLine("You have seleceted: " + drink);
                Console.WriteLine($"You have got {leftMoney}eur left");
                decimal leftMoney1 = leftMoney;
                moneyValue = (int)leftMoney1;
            }
        }

        public void BuyGroceries()
        {
            var selectedGrocery = GetSelection();
            var grocery = GroceryRepository.Groceries[selectedGrocery - 1];
            if (grocery is null || moneyValue < 0 || grocery.Price > moneyValue)
            {
                Console.WriteLine($"Meat with index {selectedGrocery - 1} does not exist OR you DO NOT have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddProduct(grocery);
                decimal leftMoney = moneyValue - grocery.Price;
                Console.WriteLine("You have seleceted: " + grocery);
                Console.WriteLine($"You have got {leftMoney}eur left");
                decimal leftMoney1 = leftMoney;
                moneyValue = (int)leftMoney1;
            }

        }

        public void ConfirmPurchase()
        {
            Console.WriteLine("Your order confimed");
            Console.WriteLine("---------------------------------------------------------------------");
            ShoppingCart.PrintCart();
            ShoppingCart.PrintCost();
            ShoppingCart.DeleteCartItems();
            Console.WriteLine("Thank you for shopping in our shop. Your order successfuly completed.");
            Console.WriteLine("---------------------------------------------------------------------");

        }



        public void PrintCandies()
        {
            foreach (Candy candy in CandyRepository.Candies)
            {
                Console.WriteLine(candy);
                Console.WriteLine("-------------------------------------------------");
            }
        }

        public void PrintMeats()
        {
            foreach (Meat meat in MeatRepository.Meats)
            {
                Console.WriteLine(meat);
                Console.WriteLine("-------------------------------------------------");

            }
        }

        public void PrintDrinks()
        {
            foreach (Drink drink in DrinkRepository.Drinks)
            {
                Console.WriteLine(drink);
                Console.WriteLine("-------------------------------------------------");

            }
        }

        public void PrintGrocery()
        {
            foreach (Grocery grocery in GroceryRepository.Groceries)
            {
                Console.WriteLine(grocery);
                Console.WriteLine("-------------------------------------------------");

            }
        }



        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Wrong format");
            return 0;
        }
    }
}
