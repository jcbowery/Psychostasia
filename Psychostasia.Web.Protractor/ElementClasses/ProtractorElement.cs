using OpenQA.Selenium;
using Protractor;
using Psychostasia.Web.ElementClasses;
using System.Drawing;

namespace Psychostasia.Web.Protractor.ElementClasses
{
    public class ProtractorElement : IElement
    {
        private readonly NgWebElement WrappedElement;

        public ProtractorElement(NgWebElement wrappedElement)
        {
            WrappedElement = wrappedElement;
        }

        public string TagName => WrappedElement.TagName;

        public string Text => WrappedElement.Text;

        public bool Enabled => WrappedElement.Enabled;

        public bool Selected => WrappedElement.Selected;

        public Point Location => WrappedElement.Location;

        public Size Size => WrappedElement.Size;

        public bool Displayed => WrappedElement.Displayed;

        public void Clear()
        {
            WrappedElement.Clear();
        }

        public void Click()
        {
            WrappedElement.Click();
        }

        public IElement FindElement(By by)
        {
            var element = WrappedElement.FindElement(by);
            return new ProtractorElement(element);
        }

        public string GetAttribute(string attributeName)
        {
            return WrappedElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return WrappedElement.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return WrappedElement.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            WrappedElement.SendKeys(text);
        }

        public void Submit()
        {
            WrappedElement.Submit();
        }
    }
}
