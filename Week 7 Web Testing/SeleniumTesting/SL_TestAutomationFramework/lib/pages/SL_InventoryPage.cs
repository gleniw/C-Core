using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL_TestAutomationFramework.lib.pages
{
    //Each class represents a page within our web test
    public class SL_InventoryPage

    {
        private IWebDriver _seleniumDriver;

        private string _inventorypage_url = AppConfigReader.BaseUrl;

        private IWebElement _addToCartBackPack => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement _addToCartBikeLight => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement _navigateToCart => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link"));

        public SL_InventoryPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitInventoryPage() => _seleniumDriver.Navigate().GoToUrl(_inventorypage_url);

        public void AddToCartBackPack() => _addToCartBackPack.Click();
        public void AddToCartBikeLight() => _addToCartBikeLight.Click();

        public void NavigateToCart() => _navigateToCart.Click();

    }
}
