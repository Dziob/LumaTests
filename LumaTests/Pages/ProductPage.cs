using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Coypu;

namespace LumaTests.Pages
{
    internal class ProductPage
    
    {
        IWebDriver driver;
        
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'XS']")]
        IWebElement XS;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'S']")]
        IWebElement S;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'M']")]
        IWebElement M;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'L']")]
        IWebElement L;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'XL']")]
        IWebElement XL;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'Blue']")]
        IWebElement blue;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'Green']")]
        IWebElement green;

        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'Purple']")]
        IWebElement purple;

        [FindsBy(How = How.Id, Using = "qty")]
        IWebElement qty;

        [FindsBy(How = How.Id, Using = "product-addtocart-button")]
        IWebElement addToCartBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='maincontent']/div[1]/div[2]/div/div/div")]
        IWebElement pageMessege;

        [FindsBy(How = How.CssSelector, Using = ".counter-number")]
        IWebElement shoppingCart;

        [FindsBy(How = How.XPath, Using = "//a[@class='action viewcart']")]
        IWebElement viewCart;


        public void ChooseSize(string size, IWebDriver driver)

        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(XS));

            if (size == "XS") {
                XS.Click();
            } else if (size == "S")
            {
                S.Click();
            } else if (size == "M")
            {
                M.Click();
            } else if (size == "L")
            {
                L.Click();
            } else if (size == "XL")
            {
                XL.Click();
            } else { throw new Exception("There is no that size option, available options; XS, S, M, L, XL."); }


        }

        public void ChooseColor(string color, IWebDriver driver)
        {
            if (color == "blue")
            {
                blue.Click();
            } else if (color == "green")
            {
                green.Click();
            } else if(color == "purple")
            {
                purple.Click();
            }else
            {
                throw new Exception("There is no that color option, available options; blue, green, purple.");
            }

            
        }

        public void qtyInput(string quantity)
        {
            qty.Clear();
            qty.SendKeys(quantity);
               
            
        }

        public void addProductToCart()
        {
            addToCartBtn.Click();
        }

        public void ConfirmAddToCartMessage (IWebDriver driver, string productName)
        {

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan (0, 0, 5));
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='maincontent']/div[1]/div[2]/div/div/div")));

            var actualMessage = pageMessege.Text;
            Assert.AreEqual(actualMessage, "You added " + productName +" to your shopping cart.");
        }

        public void ShoppingCartEnter(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            shoppingCart.Click();   
            wait.Until(ExpectedConditions.ElementToBeClickable(viewCart));
            viewCart.Click();  

        }
    }
}
