using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestingPOM.PageObjects
{
    class Homepage
    {
        private IWebDriver webdriver;

        public Homepage(IWebDriver driver)
        {
            this.webdriver = driver;
        }
        
        //declaring elements
        private IWebElement homeHeader => webdriver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/center/big/strong"));

        public Homepage GoToHomepage()
        {
            webdriver.Navigate().GoToUrl(TestData.baseURL);

            return this;
        }

        public Homepage CheckHomepageHeader()
        {
            Assert.AreEqual("1. Home", homeHeader.Text);
            Assert.IsTrue(homeHeader.Displayed);
            return this;
        }
    }
}
