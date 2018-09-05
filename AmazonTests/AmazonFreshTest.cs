using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAutomation;
using NUnit;
using NUnit.Framework;

namespace AmazonTests
{
    public class AmazonFreshTest : AmazonTest
    {
        [Test]
        public void Can_Item_Appear_In_Amazon_Fresh()

        {

            SearchBar.FindAnItem("your search");

            AmazonFresh.GoToFresh();

            NUnit.Framework.Assert.IsTrue(AmazonFresh.FreshCheck(), "Your item does not appear in Amazon Fresh");

        }

    }

    
}
