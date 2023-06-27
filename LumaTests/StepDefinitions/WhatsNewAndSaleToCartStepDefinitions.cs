using LumaTests.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.StepDefinitions
{
    [Binding]
    public class WhatsNewAndSaleToCartStepDefinitions
    {
        public IWebDriver driver;

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            string url = "https://magento.softwaretestingboard.com/";
            driver.Navigate().GoToUrl(url);
        }

        [Given("^From the menu, I choose a \"(.*)\"$")]
        public void GivenFromTheMenuIChooseA(string section)
        {
            HomePage homepage = new HomePage(driver);
            homepage.MenuSection(section);
        }

        [Given("^I enter \"(.*)\"$ ['Women's' or 'Men's' + category name]")]
        public void GivenIEnter(string category)
        {
            Section section = new Section(driver);
            section.inToWhatsNewAndSale(category);
        }

        [Given(@"I click ""([^""]*)""")]
        public void GivenIClick(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"Then I choose ""([^""]*)"", ""([^""]*)"" and ""([^""]*)""")]
        public void GivenThenIChooseAnd(string m, string green, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"I click on '([^']*)'")]
        public void GivenIClickOn(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I can see a message about adding a ""([^""]*)"" to the cart")]
        public void ThenICanSeeAMessageAboutAddingAToTheCart(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I enter the shopping cart by clicking cart icon")]
        public void ThenIEnterTheShoppingCartByClickingCartIcon()
        {
            throw new PendingStepException();
        }

        [Then(@"I check if ""([^""]*)"", ""([^""]*)"" and ""([^""]*)"" of the product are correct")]
        public void ThenICheckIfAndOfTheProductAreCorrect(string m, string green, string p2)
        {
            throw new PendingStepException();
        }
    }
}
