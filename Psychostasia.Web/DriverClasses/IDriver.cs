using OpenQA.Selenium;
using Psychostasia.Web.ElementClasses;
using System.Collections.ObjectModel;

namespace Psychostasia.Web
{
    public interface IDriver
    {
        string CurrentWindowHandle { get; }
        string PageSource { get; }
        string Title { get; }
        string Url { get; }
        ReadOnlyCollection<string> WindowHandles { get; }
        IWebDriver WrappedDriver { get; }

        void Back();
        void CloseTab();
        IElement FindElement(By by);
        ReadOnlyCollection<IElement> FindElements(By by);
        void Forward();
        void GoTo(string url);
        void GoTo(string account, string pass, string url);
        void Quit();
        void Refresh();
        void SignIntoAuthWindow(string account, string pass);
        string GrabAlertText();
    }
}