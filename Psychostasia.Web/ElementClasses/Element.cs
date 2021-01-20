using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Psychostasia.Web.ElementClasses
{
    public class Element : IElement

    {
        public Element(IWebElement wrappedElement)
        {
            WrappedElement = wrappedElement;
        }

        public IWebElement WrappedElement { get; private set; }

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

        public void RightClick(IDriver driver)
        {
            Actions actions = new Actions(driver.WrappedDriver);
            actions.ContextClick(this.WrappedElement).Perform();
        }


        public Element FindElement(By by)
        {
            var unwrappedElement = WrappedElement.FindElement(by);
            return new Element(unwrappedElement);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
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
