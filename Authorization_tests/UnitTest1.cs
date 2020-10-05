using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Authorization_tests
{
   
       
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _sign_in_button = By.Id("login");
        private readonly By _login_input_button = By.XPath("//input[@type='email']");
     //   private readonly By _continue_button = By.ClassName("VfPpkd-RLmnJb"); 
        private readonly By _password_input_button = By.XPath("//input[@type='password']");
        private readonly By _enter_button = By.Name("go");
        private readonly By _user_login = By.XPath("//button[@title='test']");


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
            //  Assert.Pass();
           var sign_in = driver.FindElement(_sign_in_button);
            sign_in.Click();
            
            var login = driver.FindElement(_login_input_button);
            login.SendKeys(_login);

           // var continue_login = driver.FindElement(_continue_button);
           // continue_login.Click();

            var password = driver.FindElement(_password_input_button);
            password.SendKeys(_password);

            var enter = driver.FindElement(_enter_button);
            enter.Click();

            Assert.AreEqual(_expected_login, _user_login, "login or enter was not done");
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}