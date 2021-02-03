using OpenQA.Selenium;
using Psychostasia.Web.DriverClasses;
using Psychostasia.Web.ElementClasses;

namespace Sandbox.Pages
{
    public class GooglePage_Selenium
    {
        readonly IDriver driver;
        public GooglePage_Selenium(IDriver driver)
        {
            this.driver = driver;
        }

        IElement SearchBar => driver.FindElement(By.Name("q"));

        public void EnterSearch(string text)
        {
            SearchBar.SendKeys(text);
            SearchBar.SendKeys(Keys.Enter);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
