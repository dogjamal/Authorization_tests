using System;
using System.Collections.Generic;
using System.Text;
using Authorization_tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Authorization_tests.Tests
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        private const string _login = "test@mail.ru";
        private const string _password = "vb";
        private const string _expected_login = "test";
        
        [Test]
        public void Test_to_sign()
        {
            var main_menu = new MainMenuPageObjects(_driver);
            main_menu
                .Sign_in()
                .Login(_login, _password);
            // .Go_to_personal_account();
            //    .Service_lists;

            Assert.Throws<NoSuchElementException>(() => main_menu.Sign_in());
       
            //   string actual_login = mainMenu.Get_user_login();

            //   Assert.AreEqual(_expected_login, actual_login, "login or enter was not done");
        }
        
    }
}
