using OpenQA.Selenium;
using System;

namespace AmazonAutomation
{
    public class CartCheck
    {

       private int Number;

        public void CartNumber(int Number)

        {
            this.Number = Number;
        }


        public static bool FirstItemsQuantityIsNumber(int CartNumber) 

        {

            var CartCount = Driver.Instance.FindElement(By.XPath("//span[@class='a-dropdown-prompt']"));
            string ItemsInCartString = CartCount.Text;
            int itemsInCart = Convert.ToInt32(value: ItemsInCartString);
            {
                if ( itemsInCart != CartNumber )
                    return false;

                else
                    return true;
            }
        }



        public static bool CartNotEmpty
        {
            get
            {

                var CartCount = Driver.Instance.FindElement(By.ClassName("nav-cart-1"));
                string itemsInCartString = CartCount.Text;
                int itemsInCart = int.Parse(itemsInCartString);
                if (itemsInCart != 1)
                    return false;
                else
                    return true;

            }
        }     
    }
}