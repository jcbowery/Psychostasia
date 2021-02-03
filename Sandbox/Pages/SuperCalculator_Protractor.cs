using OpenQA.Selenium;
using Protractor;
using Psychostasia.Web.DriverClasses;
using Psychostasia.Web.ElementClasses;

namespace Sandbox.Pages
{
    class SuperCalculator_Protractor
    {
        readonly IDriver driver;

        public SuperCalculator_Protractor(IDriver driver)
        {
            this.driver = driver;
        }

        IElement FirstNumber => driver.FindElement(NgBy.Model("first"));
        IElement SecondNumber => driver.FindElement(NgBy.Model("second"));
        IElement GoButton => driver.FindElement(By.Id("gobutton"));

        public void EnterNumbers(int first, int second)
        {
            FirstNumber.SendKeys(first.ToString());
            SecondNumber.SendKeys(second.ToString());
        }

        public void ClickGoButton()
        {
            GoButton.Click();
        }

        public string GetCalcOutput()
        {
            return driver.FindElement(By.ClassName("ng-binding")).Text;
        }
    }
}
