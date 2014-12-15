using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public class USBAdapter : Adapter
    {
        public override string ConnectionType
        {
            get { return "USB"; }
        }
    }
}
