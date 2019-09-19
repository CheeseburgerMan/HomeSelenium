using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPOM.PageObjects;

namespace TestingPOM.Tests
{
    class HomepageTests : BaseTest
    {
        Homepage home;

        [Test]
        public void GoToHomepageAndCheckTitle()
        {
            home = new Homepage(driver);

            home.GoToHomepage()
                .CheckHomepageHeader();
        }
    }
}
