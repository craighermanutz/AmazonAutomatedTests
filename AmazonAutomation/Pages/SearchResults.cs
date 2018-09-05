using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace AmazonAutomation
{
    public class SearchResults
    {
        public static void ClickItem()
        {

            Actions Interact = new Actions(Driver.Instance);

            var FirstItemFound = Driver.Instance.FindElements(By.ClassName("a-fixed-left-grid-col"))[0];

            Interact.MoveToElement(FirstItemFound).Click().Build().Perform();

        }

        public static void AddToCart()

        {
            var AddItemToCart = Driver.Instance.FindElement
            (By.Id("add-to-cart-button"));
            AddItemToCart.Click();
        }

        public static void GoToCart()
        {
            var GoToCart = Driver.Instance.FindElement(By.Id("hlb-view-cart-announce"));
            GoToCart.Click();
        }
    }
}
