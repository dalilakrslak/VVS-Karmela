using Karmela.Core.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Karmela
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Init()
        {

            _driver = new ChromeDriver();
        }

        // Dalila - Test 1
        [Test]
        public void NovostiTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/");

            IWebElement novostiButton = _driver.FindElement(By.CssSelector("#menu-item-2693>a>span>span"));

            novostiButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/novosti/";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        // Dalila - Test 2
        [Test]
        public void SoriranjeTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/");

            IWebElement sortButton = _driver.FindElement(By.CssSelector("#myhome-listing-grid>div>div:nth-child(2)>div.mh-filters>div.mh-filters__left>div.mh-filters__buttons>button:nth-child(4)"));

            sortButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/mh/?sortBy=priceLowToHigh";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}