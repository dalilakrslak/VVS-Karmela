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

        // Nejra - Test 1
        [Test]
        public void PregledDetaljiTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/nekretnine/");

            IWebElement detaljiButton = _driver.FindElement(By.CssSelector("#mh-property__17948>div.mh-estate-vertical__bottom>div>div.mh-estate-vertical__buttons-wrapper>div>div>a"));

            detaljiButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/nekretnine/zemljiste/sarajevo/zemljiste-faletici-stari-grad-sarajevo/";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        // Nejra - Test 2
        [Test]
        public void LokacijaTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/nekretnine/");

            IWebElement detaljiButton = _driver.FindElement(By.CssSelector("#mh-property__17543>div.mh-estate-vertical__bottom>div>div.mh-estate-vertical__buttons-wrapper>div>div>a"));

            detaljiButton.Click();

            Thread.Sleep(3000);

            IWebElement lokacijaButton = _driver.FindElement(By.CssSelector("#post-17543>div.mh-layout.position-relative.mh-attribute-vrsta-nekretnine__stan.mh-attribute-ponuda__prodaja.mh-attribute-grad__sarajevo.mh-attribute-zip-code__71000.mh-attribute-op--ina__novi-grad.mh-attribute-naselje__nova-otoka.mh-attribute-ulica__dzemala-bijedica.mh-attribute-sprat__12-13.mh-attribute-bedrooms__bedrooms.mh-attribute-bathrooms__bathrooms.mh-attribute-property-size__property-size.mh-attribute-grijanje__centralno-s-vlastitim-kalorimetrom-euroterm.mh-attribute-godina-izgradnje__2015>aside>div>div.position-relative>div>div.mh-estate__details__map>a"));

            lokacijaButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/nekretnine/stan/sarajevo/penthouse-stan-sa-terasom-nova-otoka/";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        //Berina - Test 1
        [Test]
        public void BlizinaNaMapiTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/nekretnine/");

            IWebElement nekretninaButton = _driver.FindElement(By.CssSelector("#mh-property__17901>div.mh-estate-vertical__content>h3>a>span"));

            nekretninaButton.Click();

            Thread.Sleep(3000);

            IWebElement mapaButton = _driver.FindElement(By.CssSelector("#myhome-estate-map>div.mh-map-controls.mh-layout>div>div.mh-map-panel>div:nth-child(2)>button"));

            mapaButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/nekretnine/kuca/busovaca/kuca-sa-okucnicom-busovaca/";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        //Berina - Test 2
        [Test]
        public void ImplicitniLoginTest()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://karmelarealestate.com/nekretnine/");

            IWebElement nekretninaButton = _driver.FindElement(By.CssSelector("#mh-property__17724>div.mh-estate-vertical__content>h3>a>span"));

            nekretninaButton.Click();

            Thread.Sleep(3000);

            IWebElement likeButton = _driver.FindElement(By.CssSelector("#post-17724>div.mh-layout.position-relative.mh-attribute-vrsta-nekretnine__stan.mh-attribute-ponuda__prodaja.mh-attribute-grad__sarajevo.mh-attribute-zip-code__71000.mh-attribute-op--ina__novo-sarajevo.mh-attribute-naselje__cengic-vila.mh-attribute-ulica__dzemala-bijedica.mh-attribute-sprat__5.mh-attribute-bedrooms__bedrooms.mh-attribute-bathrooms__bathrooms.mh-attribute-property-size__property-size.mh-attribute-grijanje__centralno-gradsko>aside>div>div.mh-estate__add-to>button"));

            likeButton.Click();

            Thread.Sleep(3000);

            string expectedUrl = "https://karmelarealestate.com/nekretnine/stan/sarajevo/stan-na-cengic-vili-trosoban/";

            Assert.That(_driver.Url, Is.EqualTo(expectedUrl));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}