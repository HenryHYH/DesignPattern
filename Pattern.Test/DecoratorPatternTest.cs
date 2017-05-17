using Pattern.DecoratorPattern;
using Xunit;

namespace Pattern.Test
{
    public class DecoratorPatternTest
    {
        public void Test()
        {
            Car car = new XiaomiCar();

            Decorator carWithBumper = new Bumper(car);
            Assert.Equal("XiaomiCar+Bumper", carWithBumper.Show());

            Decorator carWithSoundBox = new SoundBox(car);
            Assert.Equal("XiaomiCar+SoundBox", carWithSoundBox.Show());

            Decorator carWithBumperAndSoundBox = new SoundBox(carWithBumper);
            Assert.Equal("XiaomiCar+Bumper+SoundBox", carWithBumperAndSoundBox.Show());
        }
    }
}
