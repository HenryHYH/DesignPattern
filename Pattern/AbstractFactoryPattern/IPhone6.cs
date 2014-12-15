using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public class IPhone6 : Phone
    {
        public override string OS
        {
            get { return "IOS 8"; }
        }
    }
}
