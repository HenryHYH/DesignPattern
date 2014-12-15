using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactoryPattern
{
    public abstract class Factory
    {
        public abstract Phone MakePhone();

        public abstract Adapter MakeAdapter();
    }
}
