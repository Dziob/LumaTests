using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaTests.Pages
{
    internal class ShoppingCart
    {
        IWebDriver driver;

        public ShoppingCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='shopping-cart-table']/tbody/tr[1]/td[1]/div/dl/dd[1]")]
        IWebElement sizeInTheCart;

        [FindsBy(How = How.XPath, Using = "//*[@id='shopping-cart-table']/tbody/tr[1]/td[1]/div/dl/dd[2]")]
        IWebElement colorInTheCart;

        [FindsBy(How = How.XPath, Using = "//div[@class='field qty']")]
        IWebElement qtyInTheCart;

        public void CheckCart(string size, string color, string quantity)
        {
            var actualSize = sizeInTheCart.Text;
            var actualColor = colorInTheCart.Text;
            var actualQty = qtyInTheCart.Text;

            Assert.AreEqual(actualSize, size, actualColor, color, actualQty, quantity);
        }
    }
}
