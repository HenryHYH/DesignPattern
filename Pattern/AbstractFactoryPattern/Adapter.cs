using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public abstract class Adapter
    {
        public abstract string ConnectionType { get; }
    }
}
