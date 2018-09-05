using AmazonAutomation;
using NUnit.Framework;
using NUnit;

namespace AmazonTests
{
    public class LoginTests : AmazonTest
    {
        [Test]
        public void Buyer_Can_Login()
        {
            NUnit.Framework.Assert.IsTrue(DashBoardPage.IsAt, "failed to login");
        }
    }
}
