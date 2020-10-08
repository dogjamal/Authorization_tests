using System;
using System.Collections.Generic;
using System.Text;
using Authorization_tests.PageObjects;
using NUnit.Framework;

namespace Authorization_tests.Tests
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        private const string _login = "test@mail.ru";
        private const string _password = "vb";
        private const string _expected_login = "test";
        /*
        [Test]
        public object Test()
        {
            var mainMenu = new MainMenuPageObjects(_driver);
            mainMenu
                .Sign_in()
                .Login(_login, _password);
            // .Go_to_personal_account();
            //    .Service_lists;

            string actual_login = mainMenu.Get_user_login();

            Assert.AreEqual(_expected_login, actual_login, "login or enter was not done");
        }
        */
    }
}
