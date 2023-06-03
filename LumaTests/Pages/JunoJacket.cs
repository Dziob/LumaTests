using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace LumaTests.Pages
{
    internal class JunoJacket
    
    {
        IWebDriver driver;
        
        public JunoJacket(IWebDriver driver)
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

        

        IWebElement color;

        IWebElement qty;


        public void ChooseSize(string size)
        {
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
            } else { throw new Exception("No size"); }

        }
    }
}
