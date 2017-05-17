using Pattern.FacadePattern;
using Xunit;

namespace Pattern.Test
{
    public class FacadePatternTest
    {
        [Fact]
        public void Test()
        {
            NotificationFacade notification = new NotificationFacade();
            Assert.Equal("SMS-13800138000:Hello world|Email-a@a.com:Hello world", notification.Notify(1, "Hello world"));
        }
    }
}
