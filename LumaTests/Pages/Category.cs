using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
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


        public void InToProduct(string productName, IWebDriver driver)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[1][@class = 'item product product-item']")));
                IWebElement product = driver.FindElement(By.XPath("//*[contains(text(),'" + productName + "')]"));
                product.Click();
            } catch (NoSuchElementException  e)
            {
                throw new Exception("There is no such product in this category or the name of the product is misspelled. Check product name, capitalization matters", e);
            }
            
        }
    }
}
