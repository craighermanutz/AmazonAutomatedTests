using AmazonAutomation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace AmazonTests
{
    public class IncrementCartTests : AmazonTest
    {

        [Test]
        public void Buyer_Can_Increase_Quantity_Of_Item_In_Cart()
        {     

            SearchBar.FindAnItem("your search");

            SearchResults.ClickItem();

            SearchResults.AddToCart();

            SearchResults.GoToCart(); 

            CartIncrementBelowNine.IncByTwo.Select();

            NUnit.Framework.Assert.IsTrue(CartCheck.FirstItemsQuantityIsNumber(2), "Quantity does not match");

            SearchBar.EmptyCart();

        }

        [Test]
        public void Buyer_Can_Increase_Quantity_Of_Item_In_Cart_Beyond_Ten()
        {

            SearchBar.FindAnItem("your search");

            SearchResults.ClickItem();

            SearchResults.AddToCart();

            SearchResults.GoToCart();

            CartIncrementAboveNine.SelectIncrement(15);

            NUnit.Framework.Assert.IsTrue(CartCheck.FirstItemsQuantityIsNumber(15), "Quantity does not match");

            SearchBar.EmptyCart();

        }
    }
}
