
using OpenQA.Selenium;
using LumaTests.Pages;
using OpenQA.Selenium.Chrome;

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

        [Given("^I choose \"(.*)\", \"(.*)\" and \"(.*)\"$")]
        public void GivenIChooseSizeColorAndQuantity(string size, string color, string quantity)
        {
            JunoJacket junojacket = new JunoJacket(driver);
            junojacket.ChooseSize(size, driver);
            junojacket.ChooseColor(color, driver);
            junojacket.qtyInput(quantity);
            
        }

        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            JunoJacket junojacket = new JunoJacket(driver);
            junojacket.addProductToCart();

        }

        [Then(@"I can see a message about adding a product to the basket")]
        public void ThenICanSeeAMessageAboutAddingAProductToTheBasket()
        {
            JunoJacket junojacket = new JunoJacket(driver);
            junojacket.ConfirmAddToCartMessage(driver);
            
        }
        [Then(@"I go to the shopping cart by clicking cart icon")]
        public void ThenIGoToTheShoppingCartByClickingCartIcon()
        {
            JunoJacket junoJacket = new JunoJacket(driver);
            junoJacket.ShoppingCartEnter(driver);
        }


        [Then("^I can see that \"(.*)\", \"(.*)\" and \"(.*)\" of the product are correct$")]
        public void ThenICanSeeThatProductInTheCartIsCorrect(string size, string color, string qty)
        {
            
            ShoppingCart shoppingCart = new ShoppingCart(driver);
            shoppingCart.CheckCart(size, color, qty);
        }
    }
}
