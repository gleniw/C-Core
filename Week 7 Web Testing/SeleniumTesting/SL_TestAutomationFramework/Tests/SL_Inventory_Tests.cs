using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework.lib.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL_TestAutomationFramework.Tests
{
    public class SL_Inventory_Tests
    {
        private SL_Website<ChromeDriver> SL_Website = new();

        [Test]
        [Category("Happy Path")]

        public void GivenIAmOnTheInventoryPage_WhenIAddBackPack_BikeLock_ThenIClickCart_IMoveToCart()
        {
            SL_Website.SeleniumDriver.Manage().Window.Maximize();

            SL_Website.SL_Homepage.VisitHomePage();
            SL_Website.SL_Homepage.EnterUserName(AppConfigReader.UserName);
            SL_Website.SL_Homepage.EnterPassword(AppConfigReader.Password);
            Thread.Sleep(10);
            SL_Website.SL_Homepage.ClickLogInButton();

            //SL_Website.SL_InventoryPage.VisitInventoryPage();
            SL_Website.SL_InventoryPage.AddToCartBackPack();
            SL_Website.SL_InventoryPage.AddToCartBikeLight();
            SL_Website.SL_InventoryPage.NavigateToCart();
          

            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.CartPageUrl));

        }

        //[OneTimeTearDown]
        //public void CleanUp()
        //{
        //    SL_Website.SeleniumDriver.Quit(); //Quits all windows - also calls dispose
        //    //SL_Website.SeleniumDriver.Dispose(); //Gets rid of unmanged resources 

        //}
    }
}
