using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.BridgePattern
{
    public abstract class TV
    {
        public abstract string Brand { get; }

        public abstract string On();

        public abstract string Off();
    }
}
