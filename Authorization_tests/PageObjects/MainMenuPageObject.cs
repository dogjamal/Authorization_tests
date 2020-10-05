using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization_tests.PageObjects
{
    class MainMenuPageObjects
    {
        private IWebDriver _driver;

        private readonly By _sign_in_button = By.Id("login");
        private readonly By _user_login = By.XPath("//button[@title='test']");

        public MainMenuPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public AuthorizationPageObject sign_in ()
        {
            _driver.FindElement(_sign_in_button).Click();

            return new AuthorizationPageObject(_driver); 
        }

        public string get_user_login()
        {
            string user_login = _driver.FindElement(_user_login).Text;

            return user_login;
        }
    }
}
