using OpenQA.Selenium;
using System;

namespace AmazonAutomation
{
    public class CartCheck
    {

        // The commented code below is still under construction, will be used later when following tests are added,
        // left in because it will be in this class
        //private int Number;

        //public void CartNumber(int Number)

        //{
            //this.Number = Number;
        //}


        //public static bool FirstItemsQuantityIsNumber(int CartNumber) 

        //{

            //var CartCount = Driver.Instance.FindElement(By.XPath("//input[@maxlength='3']"));
            //string ItemsInCartString = CartCount.Text;
            //int itemsInCart = Convert.ToInt32(value: ItemsInCartString);
            //{
                //if ( itemsInCart != CartNumber + 3) //will need to get xpath and do that plus one 
                    //return false;

                //else
                    //return true;
            //}
        //}



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