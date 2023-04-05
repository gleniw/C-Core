using TechTalk.SpecFlow;
using SL_TestAutomationFramework.lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using SL_TestAutomationFramework.lib.pages;


namespace SL_TestAutomationFramework.BDD
{
    [Binding]
    public class SL_SigninStepDefinitions
    {
        #region Happy Path

        public SL_Website<ChromeDriver> SL_Website { get; } = new();

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            SL_Website.SL_HomePage.VisitHomePage();
        }

        [Given(@"I have entered a valid e-mail")]
        public void GivenIHaveEnteredAValidE_Mail()
        {
            SL_Website.SL_HomePage.EnterUserName(AppConfigReader.UserName);
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            SL_Website.SL_HomePage.EnterPassword(AppConfigReader.Password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            SL_Website.SL_HomePage.ClickLoginButton();
        }

        [Then(@"I should land on the invetory page")]
        public void ThenIShouldLandOnTheInvetoryPage()
        {
            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.InventoryPageUrl));
        }
        #endregion

        #region Sad Path

        [Given(@"I have entered a invalid password of ""([^""]*)""")]
        public void GivenIHaveEnteredAInvalidPasswordOf(string password)
        {
            SL_Website.SL_HomePage.EnterPassword(password);
        }

        [Then(@"I should see an error message that contains ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessageThatContains(string expected)
        {
            Assert.That(SL_Website.SL_HomePage.CheckErrorMessage(), Does.Contain(expected));
        }

        #endregion

        [AfterScenario] //Called a hook
        public void DisposedDriver()
        {
            SL_Website.SeleniumDriver.Quit(); //Quit call dispose method
        }
    }
}
