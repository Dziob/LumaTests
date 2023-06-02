﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LumaTests.Pages
{
    internal class Woman
    {
        public IWebDriver driver;

        public Woman(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Jackets']")]
        private IWebElement jackets;

        public void inToJackets()
        {
            jackets.Click();
        }
    }
}
