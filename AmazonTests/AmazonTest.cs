using AmazonAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace AmazonTests
{
    public class AmazonTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            LoginPage.GoTo();
            LoginPage.LoginAs("amazon user name here").   // A Amazon user name goes here,
                WithPassWord("account password").Login(); // and the password goes here
        }

        [TearDown]
        public void Test_Reset_And_Close()

        {
            Driver.Instance.Quit();
        }
    }
}
