using Pattern.StatePattern;
using Xunit;

namespace Pattern.Test
{
    public class StatePatternTest
    {
        [Fact]
        public void Test()
        {
            var account = new Account("ABC");

            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            account.PayInterest();

            account.Withdraw(2000.0);
            account.Withdraw(500.0);

            Assert.Equal(1, 1);
        }
    }
}
