using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVersion4.Entities
{
    internal class Drink : Product
    {
        public double Liter { get; set; }

        public override string? ToString()
        {
            return $"{ID}. {Name} with {Liter}l of liters which cost {Price}eur";
        }
    }
}
