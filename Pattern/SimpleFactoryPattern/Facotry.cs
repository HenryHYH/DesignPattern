using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.SimpleFactoryPattern
{
    public class Facotry
    {
        public static Product Make(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                throw new ArgumentNullException("productName");

            Product product = null;

            switch (productName.ToLowerInvariant())
            {
                case "car":
                    product = new Car();
                    break;
                case "game":
                    product = new Game();
                    break;
                default:
                    break;
            }

            if (null == product)
                throw new ArgumentException("No such product.");

            return product;
        }
    }
}
