using OpenQA.Selenium;
using Psychostasia.Web.ElementClasses;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Psychostasia.Web
{
    public class Driver : IDriver
    {
        public Driver(IWebDriver wrappedDriver)
        {
            WrappedDriver = wrappedDriver;
        }

        public IWebDriver WrappedDriver { get; private set; }

        public string Url => WrappedDriver.Url;

        public string Title => WrappedDriver.Title;

        public string PageSource => WrappedDriver.PageSource;

        public string CurrentWindowHandle => WrappedDriver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => WrappedDriver.WindowHandles;

        public void CloseTab()
        {
            WrappedDriver.Close();
        }

        public IElement FindElement(By by)
        {
            var unwrappedElement = WrappedDriver.FindElement(by);
            return new Element(unwrappedElement);
        }

        public ReadOnlyCollection<IElement> FindElements(By by)
        {
            var unwrappedCollection = WrappedDriver.FindElements(by);
            List<IElement> wrappedCollection = new List<IElement>();
            foreach(var element in unwrappedCollection)
            {
                wrappedCollection.Add(new Element(element));
            }
            return new ReadOnlyCollection<IElement>(wrappedCollection);
        }

        public void Quit()
        {
            WrappedDriver.Quit();
            WrappedDriver.Dispose();
        }

        public void GoTo(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }

        public void GoTo(string account, string pass, string url)
        {
            string completeUrl = "http://" + account + ":" + pass + "@" + url;
            WrappedDriver.Navigate().GoToUrl(completeUrl);
        }

        public void Refresh()
        {
            WrappedDriver.Navigate().Refresh();
        }

        public void Back()
        {
            WrappedDriver.Navigate().Back();
        }

        public void Forward()
        {
            WrappedDriver.Navigate().Forward();
        }

        public void SignIntoAuthWindow(string account, string pass)
        {
            var box = WrappedDriver.SwitchTo().Alert();
            box.SetAuthenticationCredentials(account, pass);
            box.Accept();
        }

        public string GrabAlertText()
        {
            var text = WrappedDriver.SwitchTo().Alert().Text;
            WrappedDriver.SwitchTo().Alert().Accept();
            return text;
        }

        

        
    }
}
