using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaTests.Pages
{
    internal class Jackets
    {
        IWebDriver driver;

        public Jackets(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Juno Jacket')]")]
        private IWebElement junojacket;

        public void inToJuno()
        {
            junojacket.Click();
        }
    }
}
