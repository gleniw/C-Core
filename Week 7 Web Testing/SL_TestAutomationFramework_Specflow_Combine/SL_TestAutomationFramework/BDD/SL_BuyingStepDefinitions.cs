using System;
using TechTalk.SpecFlow;
using SL_TestAutomationFramework.BDD;
using SL_TestAutomationFramework.lib.pages;
using OpenQA.Selenium.Chrome;

namespace SL_TestAutomationFramework.BDD
{
    [Binding]
    [Scope(Feature = "SL_Buying")]

    public class SL_BuyingStepDefinitions : SharedSteps
    {

        [When(@"I click to add the source labs back pack to my cart")]
        public void WhenIClickToAddTheSourceLabsBackPackToMyCart()
        {
            SL_Website.SL_InventoryPage.AddSauceLabsBackPackToBasket();
        }

        [Then(@"the basket counter should increase by (.*)")]
        public void ThenTheBasketCounterShouldIncreaseBy(int expected)
        {
            Assert.That(SL_Website.SL_InventoryPage.GetBasketCount(), Is.EqualTo(expected));
        }
    }
}
