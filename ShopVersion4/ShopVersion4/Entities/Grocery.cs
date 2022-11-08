using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVersion4.Entities
{
    internal class Grocery : Product
    {
        public double Fiber { get; set; }

        public override string? ToString()
        {
            return $"{ID}. {Name} with {Fiber}g of fiber which cost {Price}eur";
        }


    }
}
