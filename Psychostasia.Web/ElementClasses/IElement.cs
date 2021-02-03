using Psychostasia.Web.ElementSearch;
using System.Drawing;

namespace Psychostasia.Web.ElementClasses
{
    public interface IElement : IFinder
    {
        public string TagName { get; }

        public string Text { get; }

        public bool Enabled { get; }

        public bool Selected { get; }

        public Point Location { get; }

        public Size Size { get; }

        public bool Displayed { get; }

        public void Clear();


        public void Click();


        public string GetAttribute(string attributeName);


        public string GetCssValue(string propertyName);


        public string GetProperty(string propertyName);


        public void SendKeys(string text);


        public void Submit();

    }
}
