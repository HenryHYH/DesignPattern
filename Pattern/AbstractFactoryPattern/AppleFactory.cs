using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public class AppleFactory : Factory
    {
        public override Phone MakePhone()
        {
            return new IPhone6();
        }

        public override Adapter MakeAdapter()
        {
            return new LightningAdapter();
        }
    }
}
