using AmazonAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit;
using NUnit.Framework;

namespace AmazonTests
{
    public class AddToCartTests : AmazonTest
    {

        [Test]
        public void Buyer_Can_AddToCart()
        {

            SearchBar.FindAnItem("your search"); // Input an item to search for here

            SearchResults.ClickItem();

            SearchResults.AddToCart();

            SearchResults.GoToCart();

            NUnit.Framework.Assert.IsTrue(CartCheck.CartNotEmpty, "There is more than one item in your cart or no item");

            SearchBar.EmptyCart();

        }
    }
}
