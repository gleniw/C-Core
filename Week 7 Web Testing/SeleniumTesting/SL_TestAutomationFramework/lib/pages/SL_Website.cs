using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL_TestAutomationFramework.lib.pages;
using SL_TestAutomationFramework.Tests;
using SL_TestAutomationFramework.lib.driver_config;
using OpenQA.Selenium;


namespace SL_TestAutomationFramework.lib.pages
{
    // Superclass which accesses all other web pages - Base class
    public class SL_Website<T> where T : IWebDriver, new() //Making sure its an IWebDriver
    {
        #region Accessable Page Objects and Selenium Driver
        public IWebDriver SeleniumDriver { get; set; }
        public SL_HomePage SL_Homepage { get; set; }

        public SL_Inventory_Tests SL_Inventory_Tests { get; set; }

        public SL_InventoryPage SL_InventoryPage { get; set; }
        #endregion

        public SL_Website(int pageLoadInsecs = 10, int implicitWaitInsecs = 10, bool isHeadless = false)
        {
            //Getting and Instantiate our SeleniumDriverConfig in one line
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInsecs, isHeadless).Driver;
            SL_Homepage = new SL_HomePage(SeleniumDriver);
            SL_InventoryPage = new SL_InventoryPage(SeleniumDriver);
        }
    }
}
