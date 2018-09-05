using OpenQA.Selenium;

namespace AmazonAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {

            Driver.Instance.Navigate().GoToUrl("https://www.amazon.com/ap/signin?_encoding=UTF8&openid.assoc_handle=usflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2Fgp%2Fyourstore%2Fhome%3Fie%3DUTF8%26action%3Dsign-out%26path%3D%252Fgp%252Fyourstore%252Fhome%26ref_%3Dnav_youraccount_signout%26signIn%3D1%26useRedirectOnSuccess%3D1");

        }

        public static LoginCommand LoginAs(string UserName)
        {
            return new LoginCommand(UserName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassWord(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var LoginInput = Driver.Instance.FindElement(By.Id("ap_email"));
            LoginInput.SendKeys(userName);

            var loginButton = Driver.Instance.FindElement(By.Id("continue"));
            loginButton.Click();

            var passwordInput = Driver.Instance.FindElement(By.Id("ap_password"));
            passwordInput.SendKeys(password);

            var loginButtonSecond = Driver.Instance.FindElement(By.Id("signInSubmit"));
            loginButtonSecond.Click();


        }
    }
}
