using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ProxyPattern
{
    public class Ctrip : Booking
    {
        public override string BuyTicket()
        {
            Booking railwayStation = new RailwayStation();

            return railwayStation.BuyTicket();
        }
    }
}
