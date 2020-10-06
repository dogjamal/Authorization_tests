using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Authorization_tests
{
    public static class WaitUntil
    {
        public static void Shoud_locate(IWebDriver driver, string location)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(location));
            }

            catch(WebDriverTimeoutException texp)
            {
                throw new NotFoundException($"Cannot found the app in his location: {location}", texp);
            }
        }

        public static void Wait_some_interval(int seconds = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void Wait_element(IWebDriver driver, By locator, int seconds = 20)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
