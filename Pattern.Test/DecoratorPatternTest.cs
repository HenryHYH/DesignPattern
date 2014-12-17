using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;
using Pattern.DecoratorPattern;

namespace Pattern.Test
{
    public class DecoratorPatternTest
    {
        public void Test()
        {
            Car car = new XiaomiCar();

            Decorator carWithBumper = new Bumper(car);
            carWithBumper.Show().ShouldBe("XiaomiCar+Bumper");

            Decorator carWithSoundBox = new SoundBox(car);
            carWithSoundBox.Show().ShouldBe("XiaomiCar+SoundBox");

            Decorator carWithBumperAndSoundBox = new SoundBox(carWithBumper);
            carWithBumperAndSoundBox.Show().ShouldBe("XiaomiCar+Bumper+SoundBox");
        }
    }
}
