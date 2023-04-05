using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SL_TestAutomationFramework.lib.driver_config;

namespace SL_TestAutomationFramework.lib.pages
{
    // Super class - essential acting as a srvice object for all pages
    // i.e. decomposes objects in manageable classes and methods
    public class SL_Website<T> where T : IWebDriver, new()
    {
        #region Accessible Page Objects and Selenium Driver
        public IWebDriver SeleniumDriver { get; set; }
        public SL_HomePage SL_HomePage { get; set; }
        public SL_InventoryPage SL_InventoryPage { get; set; }

        #endregion

        public SL_Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10, bool isHeadless = false)
        {
            // Instantiated our driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs, isHeadless).Driver;
            SL_HomePage = new SL_HomePage(SeleniumDriver);
            SL_InventoryPage = new SL_InventoryPage(SeleniumDriver);
        }
    }
}
