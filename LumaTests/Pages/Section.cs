﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
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
        [FindsBy(How = How.ClassName, Using = "base")]
        IWebElement sectionTitle;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[1]")]
        IWebElement WNWomenHoodies;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[2]")]
        IWebElement WNWomenJackets;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[3]")]
        IWebElement WNWomenTees;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[4]")]
        IWebElement WNWomenBras;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[5]")]
        IWebElement WNWomenPants;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul/li[6]")]
        IWebElement WNWomenShorts;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[1]")]
        IWebElement WNMenHoodies;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[2]")]
        IWebElement WNMenJackets;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[3]")]
        IWebElement WNMenTees;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[4]")]
        IWebElement WNMenTanks;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[5]")]
        IWebElement WNMenPants;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[2]/li[6]")]
        IWebElement WNMenShorts;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[3]/li[1]")]
        IWebElement saleBages;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[3]/li[2]")]
        IWebElement saleFitnessEqp;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[1]/li[1]")]
        IWebElement bags;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[1]/li[2]")]
        IWebElement fitnessEquipment;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'categories-menu']/ul[1]/li[3]")]
        IWebElement watches;






        public void inToWomenMan(string category)
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

        public void inToWhatsNewAndSale(string category, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            wait.Until(ExpectedConditions.ElementToBeClickable(WNMenShorts));

            switch (category)
            {
                case "Women's Hoodies and Sweatshirts":
                    WNWomenHoodies.Click();
                    break;
                case "Women's Jackets":
                    WNWomenJackets.Click();
                    break;
                case "Women's Tees":
                    WNWomenTees.Click();
                    break;
                case "Women's Bras & Tanks":
                    WNWomenBras.Click();    
                    break;
                case "Women's Pants":
                    WNWomenPants.Click();   
                    break;
                case "Women's Shorts":
                    WNWomenPants.Click();
                    break;
                    default: throw new NotImplementedException("There is no such category option in this section. Please check the color and text format. Category needs to be written in a big first letter.");
            }
        }
    }
           

}

        
        
   

        
    

