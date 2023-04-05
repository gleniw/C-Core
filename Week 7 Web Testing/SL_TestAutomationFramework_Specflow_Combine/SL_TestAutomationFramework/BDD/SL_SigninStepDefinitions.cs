using TechTalk.SpecFlow;
using SL_TestAutomationFramework.lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using SL_TestAutomationFramework.lib.pages;
using TechTalk.SpecFlow.Assist;
using SL_TestAutomationFramework.Utils;


namespace SL_TestAutomationFramework.BDD
{

    [Binding]
    [Scope(Feature = "SL_Signin")]
    public class SL_SigninStepDefinitions : SharedSteps
    {
        #region
        //[BeforeScenario("Happy")]

        //public void ExampleOfTagScoping()
        //{
        //    SL_Website.SeleniumDriver.Navigate().GoToUrl("https://www.spurs.co.uk");
        //    Thread.Sleep(1000);
        //}

        //The above will perform the action before for only the happy paths 
        #endregion

        #region Happy Path


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

        #region Sad 2

        [Given(@"I have the following credentials")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
            //var set = table.CreateSet<Credentials>(); Use this for more rows

        }

        [Given(@"I enter these credential")]
        public void GivenIEnterTheseCredential()
        {
            SL_Website.SL_HomePage.EnterSignInCredentials(_credentials);
        }



        #endregion

        [AfterScenario] //Called a hook
        public void DisposedDriver()
        {
            SL_Website.SeleniumDriver.Quit(); //Quit call dispose method
        }
    }
}
