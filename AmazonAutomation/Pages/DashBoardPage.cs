using OpenQA.Selenium;

namespace AmazonAutomation
{
    public class DashBoardPage
    {
        public static bool IsAt
            {
                get

                {
                    var id = Driver.Instance.FindElement(By.Id("twotabsearchtextbox"));
                { 

                return true;

                }

                }
            }
    }
}
