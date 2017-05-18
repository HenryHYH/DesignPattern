using Pattern.BuilderPattern;
using Xunit;

namespace Pattern.Test
{
    public class BuilderPatternTest
    {
        [Fact]
        public void Test()
        {
            var shop = new Shop();
            VehicleBuilder carBuilder = new CarBuilder();
            VehicleBuilder motoCycleBuilder = new MotorCycleBuilder();

            shop.Construct(carBuilder);
            carBuilder.Vehicle.Show();

            shop.Construct(motoCycleBuilder);
            motoCycleBuilder.Vehicle.Show();

            Assert.Equal(1, 1);
        }
    }
}
