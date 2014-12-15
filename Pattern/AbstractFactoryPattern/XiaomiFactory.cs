using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public class XiaomiFactory : Factory
    {
        public override Phone MakePhone()
        {
            return new Hongmi4G();
        }

        public override Adapter MakeAdapter()
        {
            return new USBAdapter();
        }
    }
}
