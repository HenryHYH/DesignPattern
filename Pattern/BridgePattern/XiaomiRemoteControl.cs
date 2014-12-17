using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.BridgePattern
{
    public class XiaomiRemoteControl : RemoteControl
    {
        public XiaomiRemoteControl(TV tv) : base(tv) { }

        public override string On()
        {
            return base.On();
        }

        public override string Off()
        {
            return base.Off();
        }
    }
}
