using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Psychostasia.Web.Selenium.DriverFactory
{
    public class ChromeBrowser : Browser
    {
        public ChromeOptions Options { get; private set; }

        public ChromeBrowser()
        {
            Options = new ChromeOptions();
        }

        public override void CreateOptions(bool incognito = false, bool headless = false)
        {
            if (incognito) Options.AddArgument("--incognito");
            if (headless) Options.AddArgument("headless");
            Options.AddArgument("--start-maximized");
        }

        public override IWebDriver GetDriver()
        {
            return new ChromeDriver(Options);
        }
    }
}
