using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization_tests
{
    public class BaseTest
    {
        protected IWebDriver _driver;

        [OneTimeSetUp]
        protected void Do_before_all_tests()
        {
            _driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        protected void Do_after_all_tests()
        {

        }

        [TearDown]
        protected void Do_after_each()
        {
            _driver.Quit();
        }

        [SetUp]

        protected void Do_before_each()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl(TestSettings.Host_prefix);
            WaitUntil.Shoud_locate(_driver, TestSettings.Location_url);
        }
    }
}
