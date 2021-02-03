using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Psychostasia.Web.Selenium.DriverFactory
{
    public class FirefoxBrowser : Browser
    {
        public FirefoxOptions Options { get; private set; }

        public FirefoxBrowser()
        {
            Options = new FirefoxOptions();
        }

        public override void CreateOptions(bool incognito = false, bool headless = false)
        {
            if (incognito) Options.AddArgument("--incognito");
            if (headless) Options.AddArgument("headless");
            Options.AddArgument("--start-maximized");
        }

        public override IWebDriver GetDriver()
        {
            return new FirefoxDriver(Options);
        }
    }
}
