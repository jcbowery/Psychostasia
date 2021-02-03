using OpenQA.Selenium;
using Psychostasia.Web.DriverClasses;
using Psychostasia.Web.ElementClasses;
using System.Collections.ObjectModel;

namespace Psychostasia.Web.Selenium
{
    public class SeleniumDriver : IDriver
    {
        private readonly IWebDriver WrappedDriver;
        public SeleniumDriver(IWebDriver driver)
        {
            WrappedDriver = driver;
        }

        public string Url => WrappedDriver.Url;

        public string Title => WrappedDriver.Title;

        public string PageSource => WrappedDriver.PageSource;

        public string CurrentWindowHandle => WrappedDriver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => WrappedDriver.WindowHandles;

        public void Close()
        {
            WrappedDriver.Close();
        }

        public void Dispose()
        {
            WrappedDriver.Dispose();
        }

        public IElement FindElement(By by)
        {
            var element = WrappedDriver.FindElement(by);
            return new SeleniumElement(element);
        }

        public void GoTo(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            WrappedDriver.Quit();
        }
    }
}
