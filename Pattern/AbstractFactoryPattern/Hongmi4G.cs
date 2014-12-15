using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public class Hongmi4G : Phone
    {
        public override string OS
        {
            get { return "MIUI v6"; }
        }
    }
}
