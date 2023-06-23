using System;
using TechTalk.SpecFlow;

namespace LumaTests.StepDefinitions
{
    [Binding]
    public class WhatsNewAndSaleToCartStepDefinitions
    {
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            throw new PendingStepException();
        }

        [Given(@"From the menu, I choose a ""([^""]*)""")]
        public void GivenFromTheMenuIChooseA(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I enter ""([^""]*)""")]
        public void GivenIEnter(string tees)
        {
            throw new PendingStepException();
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
