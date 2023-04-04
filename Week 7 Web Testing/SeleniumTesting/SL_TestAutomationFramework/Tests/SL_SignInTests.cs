using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework.lib.pages;

namespace SL_TestAutomationFramework.Tests
{
    public class SL_SignInTests
    {
        private SL_Website<ChromeDriver> SL_Website = new();
        
        [Test]
        [Category ("Happy Path")]

        public void GivenIAmOnTheHomePage_WhenIEnterAValidEmailAndPassword_IshouldLandOnTheInventoryPage()
        {
            SL_Website.SeleniumDriver.Manage().Window.Maximize();

            SL_Website.SL_Homepage.VisitHomePage();
            
            SL_Website.SL_Homepage.EnterUserName(AppConfigReader.UserName);
            
            SL_Website.SL_Homepage.EnterPassword(AppConfigReader.Password);

            SL_Website.SL_Homepage.ClickLogInButton();

            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.InventoryPageUrl));

        }
        //Performed after all methods 
        [OneTimeTearDown]
        public void CleanUp()
        {
            SL_Website.SeleniumDriver.Quit(); //Quits all windows - also calls dispose
            //SL_Website.SeleniumDriver.Dispose(); //Gets rid of unmanged resources 

        }
    }
}
