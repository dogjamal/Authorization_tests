using Authorization_tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Authorization_tests
{
   
       
    public class Tests
    {
        private IWebDriver driver;

        private const string _login = "test@mail.ru";
        private const string _password = "vb";
        private const string _expected_login = "test";
        private const string _url = "https://habr.com/ru/";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_url);
            WaitUntil.Shoud_locate(driver, _url);
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObjects(driver);
            mainMenu
                .Sign_in()
                .Login(_login, _password);
             //   .Go_to_personal_account();

            string actual_login = mainMenu.Get_user_login();

            Assert.AreEqual(_expected_login, actual_login, "login or enter was not done");
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}