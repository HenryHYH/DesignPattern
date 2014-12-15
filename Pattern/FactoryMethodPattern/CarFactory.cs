using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethodPattern
{
    public class CarFactory : Factory
    {
        public override Product Make()
        {
            return new Car();
        }
    }
}
