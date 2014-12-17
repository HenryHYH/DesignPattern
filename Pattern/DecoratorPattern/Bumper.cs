using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DecoratorPattern
{
    public class Bumper : Decorator
    {
        public Bumper(Car car) : base(car) { }

        public override string Show()
        {
            return base.Show() + "+Bumper";
        }
    }
}
