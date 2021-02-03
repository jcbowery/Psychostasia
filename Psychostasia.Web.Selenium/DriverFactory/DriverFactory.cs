using OpenQA.Selenium;
using System;

namespace Psychostasia.Web.Selenium.DriverFactory
{
    public static class DriverFactory
    {
        private static Browser Browser;

        public static void SetBrowser(string browserChoice)
        {
            switch (browserChoice)
            {
                case "chrome":
                    Browser = new ChromeBrowser();
                    break;
                case "firefox":
                    Browser = new FirefoxBrowser();
                    break;
                default:
                    throw new ArgumentException("");
            }
        }

        public static IWebDriver GetDriver(bool incognito = false, bool headless = false)
        {
            switch (Browser.GetType().Name)
            {
                case "ChromeBrowser":
                    Browser.CreateOptions(incognito, headless);
                    return Browser.GetDriver();
                case "FirefoxBrowser":
                    Browser.CreateOptions(incognito, headless);
                    return Browser.GetDriver();
                default:
                    throw new ArgumentException("How the fuck even do?!?!");

            }
        }
    }
}
