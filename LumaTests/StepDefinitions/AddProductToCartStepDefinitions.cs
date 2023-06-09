
using OpenQA.Selenium;
using LumaTests.Pages;
using OpenQA.Selenium.Chrome;

namespace LumaTests.StepDefinitions
{
    [Binding]
    public class AddProductToCartStepDefinitions

    {
        private IWebDriver driver;

        [Obsolete]
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

        [Given("^I choose \"(.*)\"$")]
        public void GivenIChoose(string productName)
        {
            Jackets jackets = new Jackets(driver);
            jackets.InToProduct(productName);
        }

        [Given("^I select \"(.*)\", \"(.*)\" and \"(.*)\"$")]
        public void GivenISelectAnd(string size, string color, string quantity)
        {
            ProductPage product = new ProductPage(driver);
            product.ChooseSize(size, driver);
            product.ChooseColor(color, driver);
            product.qtyInput(quantity);
        }


        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            ProductPage product = new ProductPage(driver);
            product.addProductToCart();

        }

        [Then("^I can see a message about adding a \"(.*)\" to the basket$")]
        public void ThenICanSeeAMessageAboutAddingAProductToTheBasket(string productName)
        {
            ProductPage junojacket = new ProductPage(driver);
            junojacket.ConfirmAddToCartMessage(driver, productName);
            
        }
        [Then(@"I go to the shopping cart by clicking cart icon")]
        public void ThenIGoToTheShoppingCartByClickingCartIcon()
        {
            ProductPage junoJacket = new ProductPage(driver);
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
