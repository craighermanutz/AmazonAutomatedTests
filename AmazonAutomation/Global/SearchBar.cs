using AmazonAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTests
{
    public class SearchBar
    {

        public class FindItemCommand
        {

            public string Item;

            public void FindItem(string Item)
            {
                this.Item = Item;
            }

        }

        public static void FindAnItem(string Item)
        {
            Driver.Instance.Manage().Window.Maximize();

            var SearchBar = Driver.Instance.FindElement(By.Id("twotabsearchtextbox"));
            SearchBar.SendKeys(Item);

            var SearchButton = Driver.Instance.FindElement(By.ClassName("nav-input"));
            SearchButton.Click();
        }


        public static void EmptyCart()

        {

            var EmptyCart = Driver.Instance.FindElement(By.XPath("//input[@value='Delete']"));
            EmptyCart.Click();

        }

    }
}