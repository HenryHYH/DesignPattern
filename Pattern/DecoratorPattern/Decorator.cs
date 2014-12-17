using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DecoratorPattern
{
    public class Decorator : Car
    {
        private Car car;

        public Decorator(Car car)
        {
            this.car = car;
        }

        public override string Show()
        {
            return null != car ? car.Show() : "No car";
        }
    }
}
