using Pattern.ChainOfResponsibilityPattern;
using Xunit;

namespace Pattern.Test
{
    public class ChainOfResponsibilityPatternTest
    {
        [Fact]
        public void Test()
        {
            var reqPhone = new PurchaseRequest("Phone", 4000.0);
            var reqSoftware = new PurchaseRequest("Visual Studio", 10000.0);
            var reqComputers = new PurchaseRequest("Dell", 40000.0);

            Approver p = new President("C");
            Approver vp = new VicePresident("B")
            {
                NextApprover = p
            };
            Approver manger = new Manager("A")
            {
                NextApprover = vp
            };

            var result = manger.ProcessRequest(reqPhone);
            Assert.Equal("Approved by A", result);

            result = manger.ProcessRequest(reqSoftware);
            Assert.Equal("Approved by B", result);

            result = manger.ProcessRequest(reqComputers);
            Assert.Equal("Approved by C", result);
        }
    }
}
