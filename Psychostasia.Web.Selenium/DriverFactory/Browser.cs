using OpenQA.Selenium;

namespace Psychostasia.Web.Selenium.DriverFactory
{
    public abstract class Browser
    {
        public abstract IWebDriver GetDriver();

        public abstract void CreateOptions(bool incognito = false, bool headless = false);
    }
}
