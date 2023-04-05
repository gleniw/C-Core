using OpenQA.Selenium;
using SL_TestAutomationFramework.Utils;

namespace SL_TestAutomationFramework.lib.pages
{
    public class SL_HomePage
    {
        private IWebDriver _seleniumDriver;

        private string _homePageUrl = AppConfigReader.BaseUrl;

        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _alert => _seleniumDriver.FindElement(By.CssSelector("[data-test=\"error\"]"));

        public SL_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void EnterUserName(string username) => _usernameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);
        public void ClickLoginButton() => _loginButton.Click();
        public string CheckErrorMessage() => _alert.Text;

        public void EnterSignInCredentials(Credentials credentials)
        {
            EnterUserName(credentials.UserName);
            EnterPassword(credentials.Password);

        }
        //Passing all credentials in one method
        //Good for things like a signup form

    }
}
