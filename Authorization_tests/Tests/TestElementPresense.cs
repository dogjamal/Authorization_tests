using System;
using System.Collections.Generic;
using System.Text;
using Authorization_tests.PageObjects;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Authorization_tests.Tests 
{
    class TestElementPresense : BaseTest
    {
        [Test]
        public void Test_for_presense()
        {
            //1
            var main_menu = new MainMenuPageObjects(_driver);

            Assert.IsTrue(main_menu.Check_present_links_tab_1());

            //2
            Assert.IsTrue(main_menu.Check_present_links_tab_2());
            Assert.IsTrue(main_menu.Check_present_links_tab_21);

            //3
            Assert.Throws<NoSuchElementException>(() => main_menu.Navigate_to_links_tab());

            //4
          //  Assert.That(main_menu.All_links_tabs_text, Has.No.Member(Ma))
        }
    }
}
