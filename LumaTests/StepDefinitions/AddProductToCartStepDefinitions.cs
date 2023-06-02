using Coypu.Actions;
using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using LumaTests.Pages;

namespace LumaTests.StepDefinitions
{
    [Binding]
    public class AddProductToCartStepDefinitions

    {
        private IWebDriver driver;
        private AddProductToCartStepDefinitions() {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given(@"I enter to home page")]
        public void GivenIEnterToHomePage()
        {
           string url = "https://magento.softwaretestingboard.com/";
           driver.Navigate().GoToUrl(url);
        }

        [Given(@"I click on Women")]
        public void GivenIClickOnWomen()
        {
            HomePage homepage = new HomePage(driver);
            homepage.MenuWoman();

        }

        [Given(@"I click on Jackets")]
        public void GivenIClickOnJackets()
        {
            Woman woman = new Woman(driver);
            woman.inToJackets();
        }

        [Given(@"I choose Juno Jacket")]
        public void GivenIChooseJunoJacket()
        {
            Jackets jackets = new Jackets(driver);  
            jackets.inToJuno();
        }

        [Given(@"I choose '([^']*)' size, '([^']*)' color and quantity '([^']*)'")]
        public void GivenIChooseSizeColorAndQuantity(string s, string green, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            throw new PendingStepException();
        }

        [Then(@"I can see a message about adding a product to the basket")]
        public void ThenICanSeeAMessageAboutAddingAProductToTheBasket()
        {
            throw new PendingStepException();
        }

        [Then(@"I can see that product in the cart is correct")]
        public void ThenICanSeeThatProductInTheCartIsCorrect()
        {
            throw new PendingStepException();
        }
    }
}
