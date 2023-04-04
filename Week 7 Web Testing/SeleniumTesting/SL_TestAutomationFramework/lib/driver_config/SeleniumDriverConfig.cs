
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SL_TestAutomationFramework.lib.driver_config
{
    //New keyword - can't be asbract type
    //Specify the type when we instantiate the driverconfig
    //But the type must be of iwebdriver type
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }
        
        public SeleniumDriverConfig (int pageLoadInsecs, int implicityWaitInsec, bool isHeadless)
        {
            Driver = new T();
            DriverSetUp(pageLoadInsecs, implicityWaitInsec, isHeadless);
        }

        private void DriverSetUp(int pageLoadInsecs, int implicityWaitInsec, bool isHeadless)
        {
            //Time waits for pade to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInsecs);
            //Time waits for elements to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(implicityWaitInsec);
            //Do you want it headless
            if (isHeadless) SetHeadless();
        }

        private void SetHeadless()
        {
            if (Driver is ChromeDriver)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("headless");
                Driver = new ChromeDriver();
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
        // Tests are the most important - Basics of the Framework are important
    }
}
