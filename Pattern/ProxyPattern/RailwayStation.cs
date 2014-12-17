using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ProxyPattern
{
    public class RailwayStation : Booking
    {
        public override string BuyTicket()
        {
            return "Railway ticket";
        }
    }
}
