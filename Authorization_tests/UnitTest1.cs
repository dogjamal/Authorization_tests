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

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://habr.com/ru/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObjects(driver);
            mainMenu
                .sign_in()
                .login(_login, _password);

            string actual_login = mainMenu.get_user_login();

            Assert.AreEqual(_expected_login, actual_login, "login or enter was not done");
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}