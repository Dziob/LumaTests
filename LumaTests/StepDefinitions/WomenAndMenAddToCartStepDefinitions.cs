
using OpenQA.Selenium;
using LumaTests.Pages;
using OpenQA.Selenium.Chrome;

namespace LumaTests.StepDefinitions
{
    [Binding]
    public class WomenAndMenAddToCartStepDefinitions

    {
        private IWebDriver driver;

        [Obsolete]
        private WomenAndMenAddToCartStepDefinitions() {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
            
        }

        [Given(@"I enter to home page")]
        public void GivenIEnterToHomePage()
        {
           string url = "https://magento.softwaretestingboard.com/";
           driver.Navigate().GoToUrl(url);
        }

        [Given("^From the menu, I select a \"(.*)\"$")]
        public void GivenFromTheMenuISelectA(string section)
        {
            HomePage homepage = new HomePage(driver);
            homepage.MenuSection(section);
        }

       
        [Given("^I click on \"(.*)\"$")]
        public void GivenIClickOn(string category)
        {
            Section woman = new Section(driver);
            woman.inToWomenMan(category);
        }


        [Given("^I choose \"(.*)\"$")]
        public void GivenIChoose(string productName)
        {
            Category jackets = new Category(driver);
            jackets.InToProduct(productName, driver);
        }

        [Given("^I select \"(.*)\" , \"(.*)\" and \"(.*)\"$")]
        public void GivenISelectAnd(string size, string color, string quantity)
        {
            Product product = new Product(driver);
            product.ChooseSize(size, driver);
            product.ChooseColor(color, driver);
            product.qtyInput(quantity);
        }


        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            Product product = new Product(driver);
            product.addProductToCart();

        }

        [Then("^I can see a message about adding a \"(.*)\" to the basket$")]
        public void ThenICanSeeAMessageAboutAddingAProductToTheBasket(string productName)
        {
            Product junojacket = new Product(driver);
            junojacket.ConfirmAddToCartMessage(driver, productName);
            
        }
        [Then(@"I go to the shopping cart by clicking cart icon")]
        public void ThenIGoToTheShoppingCartByClickingCartIcon()
        {
            Product junoJacket = new Product(driver);
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
