using Psychostasia.Web;
using Psychostasia.Web.Element_Search;
using Psychostasia.Web.ElementClasses;

namespace Sandbox
{
    public class CheckBoxesPage
    {
        private readonly IDriver driver;
        private readonly string Url = "https://the-internet.herokuapp.com/checkboxes";

        public CheckBoxesPage(IDriver driver)
        {
            this.driver = driver;
        }

        private IElement CheckBox1 => driver.FindElement(Via.XPath("//input[1]"));
        private IElement CheckBox2 => driver.FindElement(Via.XPath("//input[2]"));

        public CheckBoxesPage ClickCheckBox1()
        {
            CheckBox1.Click();
            return this;
        }

        public CheckBoxesPage ClickCheckBox2()
        {
            CheckBox2.Click();
            return this;
        }

        public bool Check1IsSelected()
        {
            return CheckBox1.Selected;
        }

        public bool Check2IsSelected()
        {
            return CheckBox2.Selected;
        }

        public CheckBoxesPage GoTo()
        {
            driver.GoTo(Url);
            return this;
        }
    }
}