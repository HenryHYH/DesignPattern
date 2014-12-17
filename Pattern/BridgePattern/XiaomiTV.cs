using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.BridgePattern
{
    public class XiaomiTV : TV
    {
        public override string Brand
        {
            get { return "Xiaomi"; }
        }

        public override string On()
        {
            return Brand + "TV on";
        }

        public override string Off()
        {
            return Brand + "TV off";
        }
    }
}
