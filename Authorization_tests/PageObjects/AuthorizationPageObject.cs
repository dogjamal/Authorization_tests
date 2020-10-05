using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization_tests.PageObjects
{
   
    class AuthorizationPageObject
    {
        private IWebDriver _driver;

        private readonly By _login_input_button = By.XPath("//input[@type='email']");
        //   private readonly By _continue_button = By.ClassName("VfPpkd-RLmnJb"); 
        private readonly By _password_input_button = By.XPath("//input[@type='password']");
        private readonly By _enter_button = By.Name("go");

        public AuthorizationPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public MainMenuPageObjects login(string login, string password)
        {
            _driver.FindElement(_login_input_button).SendKeys(login);
            // _driver.FindElement(_continue_button).Click();
            _driver.FindElement(_password_input_button).SendKeys(password);
            _driver.FindElement(_enter_button).Click();

            return new MainMenuPageObjects(_driver);
        }
    }
}
