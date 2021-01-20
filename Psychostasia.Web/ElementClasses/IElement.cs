using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Psychostasia.Web.ElementClasses
{
    public interface IElement
    {
        bool Displayed { get; }
        bool Enabled { get; }
        Point Location { get; }
        bool Selected { get; }
        Size Size { get; }
        string TagName { get; }
        string Text { get; }
        IWebElement WrappedElement { get; }

        void Clear();
        void Click();
        void RightClick(IDriver driver);
        Element FindElement(By by);
        ReadOnlyCollection<IWebElement> FindElements(By by);
        string GetAttribute(string attributeName);
        string GetCssValue(string propertyName);
        string GetProperty(string propertyName);
        void SendKeys(string text);
        void Submit();
    }
}