using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace SeleniumTesting
{
    public class Tests
    {

        [Test]
        [Category("Happy")]
        public void GivenIAmOnTheHomePage_WhenIEnterAValidEmailAndPassword_IshouldLandOnTheInventoryPage()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless"); // for firefox you would change the driver and change headless to --headless
            //The above should run the test without opening a new browser

            using (IWebDriver driver = new ChromeDriver(options)) //options added to implement the above
            {
                //GIVEN 
                //WHEN
                //THEN

                //ARRANGE 
                //ACT
                //ASSERT

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com");
                var userNameField = driver.FindElement(By.Id("user-name"));
                userNameField.SendKeys("standard_user");
                var passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                var loginButton = driver.FindElement(By.Name("login-button"));
                Thread.Sleep(1000);
                loginButton.Click();
                Thread.Sleep(1000);
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));

                //Do not use x-path

            }

            //Anything in this block will be using the above resource, once finished, dispose of it
            //It must implement the idisposable interface i.e. once we leave the closing block it will close the connection
        }

        [Test]
        [Category("Sad")]
        public void GivenIAmOnTheHomePage_IEnterValidEmailAndInvalidPassword_ThenIShouldReceiveAnErrorMessage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com");
                var userNameField = driver.FindElement(By.Id("user-name"));
                userNameField.SendKeys("standard_user");
                var passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("wrong_password");
                var loginButton = driver.FindElement(By.Name("login-button"));
                Thread.Sleep(1000);
                loginButton.Click();
                Thread.Sleep(1000);
                //NISH WORKING SOLUTION
                IWebElement alert = driver.FindElement(By.ClassName("error-message-container")).FindElement(By.TagName("H3"));
                Assert.That(alert.Text, Does.Contain("Epic Sadface").IgnoreCase);


                ////GS var errorMessage = driver.FindElement(By.CssSelector("*[data - test = \"error\"]"));
                //var errorMessage = driver.FindElement(By.CssSelector("*[data-test=\"error\"]")).Text;
                ////GS Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
                //Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));

            }
        }

        [Test]
        [Category("Happy")]
        public void GivenIAmOnTheDragAndDropPage_WhenIDragBoxAToBoxB_ThenTheBoxesHaveSwitchedPositions()
        {
            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://demoqa.com/droppable/");

                Actions actions = new Actions(driver);

                var dragLocation = driver.FindElement(By.Id("draggable"));
                var dropLocation = driver.FindElement(By.Id("droppable"));

                actions.ClickAndHold(dragLocation)
                    .MoveToElement(dropLocation)
                    .Release()
                    .Perform();
                
                //actions.DragAndDropToOffset(dragLocation, dropLocation)
                //    .Build()
                //    .Perform();
            }
        }
    }
}