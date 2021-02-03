using OpenQA.Selenium;
using Psychostasia.Web.ElementClasses;

namespace Psychostasia.Web.ElementSearch
{
    public interface IFinder
    {
        public IElement FindElement(By by);
    }
}
