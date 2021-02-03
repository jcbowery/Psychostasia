using OpenQA.Selenium;
using Protractor;
using Psychostasia.Web.DriverClasses;
using Psychostasia.Web.ElementClasses;
using Psychostasia.Web.Protractor.ElementClasses;
using System.Collections.ObjectModel;

namespace Psychostasia.Web.Protractor
{
    public class ProtractorDriver : IDriver
    {
        private readonly NgWebDriver WrappedDriver;

        public ProtractorDriver(NgWebDriver wrappedDriver)
        {
            WrappedDriver = wrappedDriver;
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
            return new ProtractorElement(element);
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
