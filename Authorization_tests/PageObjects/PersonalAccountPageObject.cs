using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization_tests.PageObjects
{
    class PersonalAccountPageObject
    {
        private IWebDriver _driver;

        public PersonalAccountPageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
