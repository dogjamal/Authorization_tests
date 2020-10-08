using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Authorization_tests.PageObjects
{
    class MainMenuPageObjects
    {
        private IWebDriver _driver;

        private readonly By _sign_in_button = By.Id("login");
        private readonly By _user_login = By.XPath("//button[@title='test']");
        private readonly By _personal_account_button = By.XPath("//button[@title='account']");
        private readonly By _service_lists = By.CssSelector("span#dropdown-control");
        private readonly string  _service_list = "dropdown-control";
        //    private readonly By _all_links_tabs = By.CssSelector("span#dropdown-control");


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
        
        /*
        public MainMenuPageObjects Service_lists(string name_sort)
        {
            WaitUntil.Wait_element(_driver, _service_lists);
            _driver.FindElement(_service_lists).Click();

            //  not a separate list under Linq
            //  var sort_by = _driver.FindElement(_service_lists).First(x => x.Text == name_sort);

            return this;
        }
        */

        //1
        public bool Check_present_links_tab_1()
        {
            try
            {
                _driver.FindElement(_service_lists);

                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

        //2
        public bool Check_present_links_tab_2()
        {
            try
            {
                _driver.PageSource.Contains(_service_list);

                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        
        public bool Check_present_links_tab_21 =>
            _driver.PageSource.Contains(_service_list);

        //3
        public MainMenuPageObjects Navigate_to_links_tab()
        {
            _driver.FindElement(_service_lists).Click();

            return this;
        }

        //4
        //  public List<string> All_links_tabs_text =>
        //     _driver.FindElement(_all_links_tabs).Select(x => x.Text).ToList();
    }
}
