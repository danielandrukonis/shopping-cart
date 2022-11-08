namespace ShopVersion4.Entities
{
    internal class Candy : Product
    {
        public double SugarAmountInGrams { get; set; }

        public override string? ToString()
        {
            return $"{ID}. {Name} with {SugarAmountInGrams}g of sugar which cost {Price}eur";
        }
    }
}
