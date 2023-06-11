using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaTests.Pages
{
    internal class Category
    {
        IWebDriver driver;

        public Category(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void InToProduct(string productName)
        {
            try
            {
                IWebElement product = driver.FindElement(By.XPath("//*[contains(text(),'" + productName + "')]"));
                product.Click();
            } catch (NoSuchElementException  e)
            {
                throw new Exception("There is no such product in this category or the name of the product is misspelled. Check product name, capitalization matters", e);
            }
            
        }
    }
}
