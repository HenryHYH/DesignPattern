using Pattern.ProxyPattern;
using Xunit;

namespace Pattern.Test
{
    public class ProxyPatternTest
    {
        [Fact]
        public void Test()
        {
            Booking booking = new Ctrip();
            Booking railway = new RailwayStation();

            Assert.Equal(railway.BuyTicket(), booking.BuyTicket());
        }
    }
}
