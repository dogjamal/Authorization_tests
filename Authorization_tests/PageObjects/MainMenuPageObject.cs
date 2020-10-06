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
        private readonly By _personal_account_button = By.XPath("//button[@title='account']");

        public MainMenuPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public AuthorizationPageObject Sign_in ()
        {
            _driver.FindElement(_sign_in_button).Click();

            return new AuthorizationPageObject(_driver); 
        }

        public string Get_user_login()
        {
            string user_login = _driver.FindElement(_user_login).Text;

            return user_login;
        }

        public PersonalAccountPageObject Go_to_personal_account()
        {
            WaitUntil.Wait_element(_driver, _personal_account_button);
            _driver.FindElement(_personal_account_button).Click();

            return new PersonalAccountPageObject(_driver);
        }
    }
}
