using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SL_TestAutomationFramework.lib.driver_config
{
    // New keyword - can't be abstract type
    // Specify the type when we instantiate the DriverConfig
    // But the type MUST be of IWebDriver type
    public class SeleniumDriverConfig<T> where T : IWebDriver,new()
    {
        // Driver property for later use
        public IWebDriver Driver { get; set; }
        public SeleniumDriverConfig(int pageLoadInsecs, int implicitWaitInSecs, bool isHeadless)
        {
   
            Driver = new T();
            DriverSetUp(pageLoadInsecs, implicitWaitInSecs, isHeadless);
        }

        private void DriverSetUp(int pageLoadInsecs, int implicitWaitInSecs, bool isHeadless)
        {
            // This the the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInsecs);
            // This is the time the driver waits for the elemnts to load
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
            if (isHeadless) SetHeadless();
        }

        private void SetHeadless()
        {
            if (Driver is ChromeDriver)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("headless");
                Driver = new ChromeDriver(options);
            }
            else if (Driver is FirefoxDriver)
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArgument("--headless");
                Driver = new FirefoxDriver(options);
            }
            else
            {
                throw new ArgumentException("Driver not supported by framework");
            }
        }
    }
}
