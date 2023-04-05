using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework.lib.pages;
using SL_TestAutomationFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SL_TestAutomationFramework.BDD
{
    public class SharedSteps
    {
        //Using inheritance to make step definitions dry


        protected SL_Website<ChromeDriver> SL_Website { get; } = new(); //could also be a property
        protected Credentials? _credentials;

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            GivenIAmOnTheHomePage();
            GivenIHaveEnteredAValidE_Mail();
            SL_Website.SL_HomePage.EnterPassword(AppConfigReader.Password);
            SL_Website.SL_HomePage.ClickLoginButton();
        }


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

        [AfterScenario]
        public void DisposedDriver()
        {
            SL_Website.SeleniumDriver.Quit();
        }
    }
}
