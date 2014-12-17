using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FacadePattern
{
    public class SmsSystem
    {
        public string Send(string mobile, string message)
        {
            return string.Format("SMS-{0}:{1}", mobile, message);
        }
    }
}
