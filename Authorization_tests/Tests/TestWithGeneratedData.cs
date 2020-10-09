using System;
using System.Collections.Generic;
using System.Text;
using Authorization_tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Authorization_tests.Tests
{
    [TestFixture]
    class TestWithGeneratedData : BaseTest
    {
        [Test]
        public void Test_with_generated_data()
        {
            var main_menu = new MainMenuPageObjects(_driver);
            main_menu
                .Sign_in()
                .Login(TestGenerateData.Generate_random_mail("gmail",10), TestGenerateData.Generate_random_password(10));

          //  Assert.Throws<NoSuchElementException>(() => main_menu. ());
        }
    }
}
