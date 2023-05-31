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

        [FindsBy(How = How.XPath, Using = "//li[@class='level0 nav-2 category-item level-top parent ui-menu-item']level0 nav-2 category-item level-top parent ui-menu-item")]
        IWebElement menuWoman;

        public void MenuWoman()
        {
            menuWoman.Click();
        }

        
    }
}

