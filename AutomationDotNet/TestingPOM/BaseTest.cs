using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPOM
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownDriver()
        {
            driver.Quit();
        }
    }
}
