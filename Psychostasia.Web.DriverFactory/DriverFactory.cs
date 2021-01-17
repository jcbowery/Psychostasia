namespace Psychostasia.Web.DriverFactory
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    public class DriverFactory
    {
        private readonly Browsers browser;
        public DriverFactory(Browsers browser) => this.browser = browser;
        public ChromeOptions ChromeOptions { get; private set; }
        public FirefoxOptions FirefoxOptions { get; private set; }

        /// <summary>
        /// Sets the browser to incognito mode
        /// </summary>
        public void AddIncognito()
        {
            switch (this.browser)
            {
                case Browsers.Chrome:
                    if (this.ChromeOptions == null)
                    {
                        this.ChromeOptions = new ChromeOptions();
                    }
                    this.ChromeOptions.AddArguments("--incognito");
                    break;
                case Browsers.Firefox:
                    if (this.FirefoxOptions == null)
                    {
                        this.FirefoxOptions = new FirefoxOptions();
                    }
                    this.FirefoxOptions.AddArguments("-private");
                    break;
                case Browsers.Edge:
                    break;
                case Browsers.Ie:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Adds the headless argument to the driver
        /// </summary>
        public void AddHeadless()
        {
            switch (this.browser)
            {
                case Browsers.Chrome:
                    if (this.ChromeOptions == null)
                    {
                        this.ChromeOptions = new ChromeOptions();
                    }
                    this.ChromeOptions.AddArguments("--headless");
                    break;
                case Browsers.Firefox:
                    if (this.FirefoxOptions == null)
                    {
                        this.FirefoxOptions = new FirefoxOptions();
                    }
                    this.FirefoxOptions.AddArguments("--headless");
                    break;
                case Browsers.Edge:
                    break;
                case Browsers.Ie:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Uses the browser property set by the contructor to return the driver
        /// </summary>
        /// <returns>IWebDriver (Chrome,firefox,edge, or ie)</returns>
        public IWebDriver Build()
        {
            switch (this.browser)
            {
                case Browsers.Chrome:
                    if (this.ChromeOptions == null)
                    {
                        this.ChromeOptions = new ChromeOptions();
                    }
                    return new ChromeDriver(this.ChromeOptions);
                case Browsers.Firefox:
                    if (this.FirefoxOptions == null)
                    {
                        this.FirefoxOptions = new FirefoxOptions();
                    }
                    return new FirefoxDriver(this.FirefoxOptions);
                case Browsers.Edge:
                    break;
                case Browsers.Ie:
                    break;
                default:
                    break;
            }
            return null;


        }
    }
}
