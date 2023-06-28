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
    internal class Product
    {
        IWebDriver driver;
        
        public Product(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@option-label = 'XS']")]
        IWebElement XS;

       
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
            wait.Until(ExpectedConditions.ElementToBeClickable(addToCartBtn));
            try
            {
                IWebElement sizeChoose = driver.FindElement(By.XPath("//div[@option-label = '" + size + "']"));
                sizeChoose.Click();
            } catch (Exception ex)
            {
                throw new NoSuchElementException("There is no such size option for this product.");
            }

        }

        public void ChooseColor(string color, IWebDriver driver)
        {
            try
            {
                IWebElement colorChoose = driver.FindElement(By.XPath("//div[@option-label = '" + color + "']"));
                colorChoose.Click();
            } catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("There is no such color option for this product. Please check the color and text format. Color needs to be written in a big first letter.", e);
                
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

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan (0, 0, 15));
            
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
