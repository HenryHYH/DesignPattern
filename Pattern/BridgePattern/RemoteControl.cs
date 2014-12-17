using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.BridgePattern
{
    public abstract class RemoteControl
    {
        private TV tv;

        public RemoteControl(TV tv)
        {
            this.tv = tv;
        }

        public virtual string On()
        {
            return tv.On();
        }

        public virtual string Off()
        {
            return tv.Off();
        }
    }
}
