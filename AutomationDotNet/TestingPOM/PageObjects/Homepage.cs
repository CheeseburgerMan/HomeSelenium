using System;
using System.Configuration;
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
        
        #region elements
        //intro elements
        private IWebElement HomeHeading => webdriver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/center/big/strong"));
        private IWebElement IntroString1 => webdriver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/p[2]"));
        private IWebElement IntroString2 => webdriver.FindElement(By.XPath("/html/body/table/tbody/tr/td[1]/p[3]"));
        //header elements
        private IWebElement HomeHeaderLink => webdriver.FindElement(By.XPath("/html/body/div/center/table/tbody/tr[2]/td/div/center/table/tbody/tr/td[2]/p/small/a[1]"));
        private IWebElement DatabaseHeaderLink => webdriver.FindElement(By.XPath("/html/body/div/center/table/tbody/tr[2]/td/div/center/table/tbody/tr/td[2]/p/small/a[2]"));
        private IWebElement AddAUserHeaderLink => webdriver.FindElement(By.XPath("/html/body/div/center/table/tbody/tr[2]/td/div/center/table/tbody/tr/td[2]/p/small/a[3]"));
        private IWebElement LoginHeaderLink => webdriver.FindElement(By.XPath("/html/body/div/center/table/tbody/tr[2]/td/div/center/table/tbody/tr/td[2]/p/small/a[4]"));
        private IWebElement GetDBOnlineHeaderLink => webdriver.FindElement(By.XPath("/html/body/div/center/table/tbody/tr[2]/td/div/center/table/tbody/tr/td[2]/p/small/a[5]"));
        #endregion elements

        public Homepage GoToHomepage()
        {
            webdriver.Navigate().GoToUrl(System.Configuration.ConfigurationManager.AppSettings["baseURL"]);

            return this;
        }

        #region Homepage asserts
        public Homepage CheckHomepageHeading()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestData.ExpectedHomepageHeading, HomeHeading.Text);
                Assert.IsTrue(HomeHeading.Displayed);
            });
            
            return this;
        }

        public Homepage CheckIntroStrings()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestData.ExpectedIntroString1, IntroString1.Text);
                Assert.AreEqual(TestData.ExpectedIntroString2, IntroString2.Text);
            });
            
            return this;
        }

        public Homepage CheckHeaderLinksDisplayed()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(HomeHeaderLink.Displayed);
                Assert.IsTrue(DatabaseHeaderLink.Displayed);
                Assert.IsTrue(AddAUserHeaderLink.Displayed);
                Assert.IsTrue(LoginHeaderLink.Displayed);
                Assert.IsTrue(GetDBOnlineHeaderLink.Displayed);
            });
            
            return this;
        }

        public Homepage CheckHeaderLinksHaveCorrectText()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestData.ExpectedHomeHeaderLinkText, HomeHeaderLink.Text);
                Assert.AreEqual(TestData.ExpectedDBHeaderLinkText, DatabaseHeaderLink.Text);
                Assert.AreEqual(TestData.ExpectedAddUserHeaderLinkText, AddAUserHeaderLink.Text);
                Assert.AreEqual(TestData.ExpectedLoginHeaderLinkText, LoginHeaderLink.Text);
                Assert.AreEqual(TestData.ExpectedDBOnlineHeaderLinkText, GetDBOnlineHeaderLink.Text);
            });
            
            return this;
        }

        public Homepage CheckHeaderLinkHREFs()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestData.ExpectedHomeHeaderLinkHREF, HomeHeaderLink.GetAttribute("href"));
                Assert.AreEqual(TestData.ExpectedDBHeaderLinkHREF, DatabaseHeaderLink.GetAttribute("href"));
                Assert.AreEqual(TestData.ExpectedAddUserHeaderLinkHREF, AddAUserHeaderLink.GetAttribute("href"));
                Assert.AreEqual(TestData.ExpectedLoginHeaderLinkHREF, LoginHeaderLink.GetAttribute("href"));
                Assert.AreEqual(TestData.ExpectedDBOnlineHeaderLinkHREF, GetDBOnlineHeaderLink.GetAttribute("href"));
            });
            
            return this;
        }
        #endregion Homepage asserts
    }
}
