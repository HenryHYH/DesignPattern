using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Should;
using Xunit.Extensions;
using Pattern.FacadePattern;

namespace Pattern.Test
{
    public class FacadePatternTest
    {
        [Fact]
        public void Test()
        {
            NotificationFacade notification = new NotificationFacade();
            notification.Notify(1, "Hello world")
                .ShouldBe("SMS-13800138000:Hello world|Email-a@a.com:Hello world");
        }
    }
}
