using Coypu;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Runtime.CompilerServices;
using SeleniumExtras.WaitHelpers;



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

        [FindsBy(How = How.XPath, Using = "//*[@id='ui-id-4']/span[1]")]
        private IWebElement menuWoman;

        public void MenuWoman() 
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
           
            wait.Until(ExpectedConditions.ElementToBeClickable(menuWoman));
            menuWoman.Click();
        }

        
    }
}

