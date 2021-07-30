using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumTestsOnContainers
{
    [TestFixture]
    public class SeleniumTests
    {
        private RemoteWebDriver _driver;
        public TestContext TestContext { get; set; }

        [SetUp]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--incognito");
            //options.AddUserProfilePreference("download.default_directory", @"D:\tmp");
            //options.AddUserProfilePreference("download.prompt_for_download", false);
            //options.AddUserProfilePreference("disable-popup-blocking", "true");

            // To run tests on your local machine web driver
            // var driver = new ChromeDriver("../../../chromedriver78/", options);
            // var remoteWebDriverUrl = (string)TestContext.Properties["remoteWebDriverUrl"];

            //var remoteWebDriverUrl = "http://localhost:4444/wd/hub";
            //_driver = new RemoteWebDriver(new Uri(remoteWebDriverUrl), options);

            _driver = new ChromeDriver(PathHelper.CurrentAssemblyPath, options, TimeSpan.FromMinutes(6));
        }

        [Test]
        public void PageLive_Test()
        {
            _driver.Manage().Window.Maximize();
            //_driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            _driver.Navigate().GoToUrl("https://www.google.ca");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(_driver.PageSource.Contains("About"));
        }
    }
}
