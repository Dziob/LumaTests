using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Runtime.CompilerServices;


namespace LumaTests.Pages
{

    class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        IWebElement menuWoman;

        
    }
}

