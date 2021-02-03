using OpenQA.Selenium;
using Psychostasia.Web.ElementClasses;
using System.Drawing;

namespace Psychostasia.Web.Selenium
{
    public class SeleniumElement : IElement
    {
        readonly IWebElement WrappedWebElement;
        public SeleniumElement(IWebElement element)
        {
            WrappedWebElement = element;
        }

        public string TagName => WrappedWebElement.TagName;

        public string Text => WrappedWebElement.Text;

        public bool Enabled => WrappedWebElement.Enabled;

        public bool Selected => WrappedWebElement.Selected;

        public Point Location => WrappedWebElement.Location;

        public Size Size => WrappedWebElement.Size;

        public bool Displayed => WrappedWebElement.Displayed;

        public void Clear()
        {
            WrappedWebElement.Clear();
        }

        public void Click()
        {
            WrappedWebElement.Click();
        }

        public IElement FindElement(By by)
        {
            var element = WrappedWebElement.FindElement(by);
            return new SeleniumElement(element);
        }

        public string GetAttribute(string attributeName)
        {
            return WrappedWebElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return WrappedWebElement.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return WrappedWebElement.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            WrappedWebElement.SendKeys(text);
        }

        public void Submit()
        {
            WrappedWebElement.Submit();
        }
    }
}
