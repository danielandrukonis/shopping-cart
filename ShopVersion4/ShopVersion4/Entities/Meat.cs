namespace ShopVersion4.Entities
{
    internal class Meat : Product
    {
        public double Protein { get; set; }

        public override string? ToString()
        {
            return $"{ID}. Meat {Name} with {Protein}g of protein which cost {Price}eur";
        }
    }
}
