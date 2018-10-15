using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    [TestFixture]
    public class FirstProject_01
    {

        [Test]
        public void Site_header_is_on_home_page()
        {

            IWebDriver browser = new FirefoxDriver();
            // firefox's proxy driver is already in the folder
            browser.Navigate().GoToUrl("https://google.com");
            IWebElement header = browser.FindElement(By.Id("hplogo"));
            Assert.True(header.Displayed);
            browser.Close();
         }

        [Test]
        public void Site_lolg_must_be_on_chrome()
        {
            IWebDriver chromeBrowser = new ChromeDriver();
            chromeBrowser.Navigate().GoToUrl("https://google.com");
            IWebElement hplogo = chromeBrowser.FindElement(By.Id("hplogo"));
            Assert.True(hplogo.Displayed);
            chromeBrowser.Close();

        }

        [Test]
        public void Gmail_is_on_home_page()
        {
            IWebDriver browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("https://google.com");
            IWebElement gmail = browser.FindElement(By.ClassName("gb_P"));
            Assert.True(gmail.Displayed);
            browser.Close();
        }
    }
}
