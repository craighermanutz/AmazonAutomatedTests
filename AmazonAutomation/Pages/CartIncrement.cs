using OpenQA.Selenium;
using AmazonAutomation;
using System;

namespace AmazonTests
{
   public class CartIncrementAboveNine

        {

            int IncNinePlusInput;

            public void IncAmount(int IncNinePlusInput)

            {

                this.IncNinePlusInput = IncNinePlusInput;

            }

            public static void SelectIncrement(int IncAmount)

            {

                int CartAmount = IncAmount;
                string CartString = Convert.ToString(CartAmount);


                {

                    Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                    //System.Threading.Thread.Sleep(2000);
                    Driver.Instance.FindElement(By.Id("dropdown1_9")).Click();
                    Driver.Instance.FindElement(By.ClassName("a-input-text")).SendKeys(CartString);
                    Driver.Instance.FindElement(By.Id("a-autoid-1")).Click();

                }

            }

        }

    
    public class CartIncrementBelowNine

    {
        public class IncByOne

        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_0")).Click();
            }
        }

        public class IncByTwo
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_1")).Click();
            }
        }

        public class IncByThree
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_2")).Click();
            }
        }

        public class IncByFour
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_3")).Click();
            }
        }

        public class IncByFive
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_4")).Click();
            }
        }

        public class IncBySix
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_5")).Click();
            }
        }

        public class IncBySeven
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_6")).Click();
            }
        }

        public class IncByEight
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_7")).Click();
            }
        }

        public class IncByNine
        {
            public static void Select()

            {
                Driver.Instance.FindElement(By.Id("a-autoid-0-announce")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.Instance.FindElement(By.Id("dropdown1_8")).Click();
            }
        }

    }
}

    
