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


        [FindsBy(How = How.Id, Using = "ui-id-3")]
        IWebElement menuWhatsNew;

        [FindsBy(How = How.Id, Using = "ui-id-4")]
        IWebElement menuWoman;

        [FindsBy(How = How.Id, Using = "ui-id-5")]
        IWebElement menuMen;

        [FindsBy(How = How.Id, Using = "ui-id-6")]
        IWebElement menuGear;

        [FindsBy(How = How.Id, Using = "ui-id-7")]
        IWebElement menuTraning;

        [FindsBy(How = How.Id, Using = "ui-id-8")]
        IWebElement menuSale;



        public void MenuSection(string section) 
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
           
            wait.Until(ExpectedConditions.ElementToBeClickable(menuWoman));
            
            if (section== "What's New")
            {
                menuWhatsNew.Click();
            } else if (section == "Women")
            {
                menuWoman.Click();
            } else if (section == "Men")
            {
                menuMen.Click();
            } else if (section == "Gear")
            {
                menuGear.Click();
            } else if (section == "Training")
            {
                menuTraning.Click();
            } else if (section == "Sale")
            {
                menuSale.Click();
            }
            else
            {
                throw new Exception("There is no such section in the menu. Please check the section name and text format. Sections needs to be written in a big first letter.");
            }
        }

        
    }
}

