using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonAutomation
{
    public class AmazonFresh
    {

        public static void GoToFresh()

        {

            var CheckBox = Driver.Instance.FindElement(By.XPath("//input[@name='s-ref-checkbox-11292696011']"));
            CheckBox.Click();

        }

        public static bool FreshCheck()

        {

            try
            {
                var NotInFresh = Driver.Instance.FindElement(By.XPath("//h1[@id='noResultsTitle']")); 
            }

            catch (Exception)
            {
                var InFresh = Driver.Instance.FindElement(By.XPath("//span[@id='s-result-count']")); 

                if (InFresh != null)
                    return false;

            }

            return true;
        }
    }
}
