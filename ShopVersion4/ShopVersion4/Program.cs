using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using ShopVersion4;
using ShopVersion4.Entities;
using ShopVersion4.Repositories;

public class Program
{
    public static void Main(string[] args)
    { 
        var candyRepository = new CandyRepository();
        var meatRepository = new MeatRepository();
        var drinkRepository = new DrinkRepository();
        var groceryRepository = new GroceryRepository();

        var menu = new Menu();
        menu.InitiateMenu();
    }
}