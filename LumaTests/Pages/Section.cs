using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LumaTests.Pages
{
    internal class Section
    {
        public IWebDriver driver;

        public Section(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }



        public void inToCategory(string category)
        {
            try
            {
                IWebElement categoryChoose = driver.FindElement(By.XPath("//a[text() = '" + category + "']")); 
                categoryChoose.Click();
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("There is no such category option in this section. Please check the color and text format. Category needs to be written in a big first letter.", e);

            }
        }
    }
}
