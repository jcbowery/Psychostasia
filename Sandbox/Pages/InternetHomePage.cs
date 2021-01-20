using Psychostasia.Web;
using Psychostasia.Web.Element_Search;
using Psychostasia.Web.ElementClasses;

namespace Sandbox
{
    public class InternetHomePage
    {
        private readonly IDriver Driver;

        public InternetHomePage(IDriver driver)
        {
            Driver = driver;
        }

        private IElement ABTestingLink => Driver.FindElement(Via.XPath("//a[.='A/B Testing']"));
        private IElement AddRemoveElementLink => Driver.FindElement(Via.XPath("//a[.='Add/Remove Elements']"));
        private IElement BasicAuthLink => Driver.FindElement(Via.XPath("//a[.='Basic Auth']"));
        private IElement CheckBoxesLink => Driver.FindElement(Via.XPath("//a[.='Checkboxes']"));
        private IElement ContextMenuLink => Driver.FindElement(Via.XPath("//a[.='Context Menu']"));

        public AddRemoveElementPage ClickAddRemoveLementLink()
        {
            AddRemoveElementLink.Click();
            return new AddRemoveElementPage(Driver);
        }

        public ABTestingPage ClickAbTestingLink()
        {
            ABTestingLink.Click();
            return new ABTestingPage(Driver);
        }

        public BasicAuthPage ClickBasicAuthLink()
        {
            BasicAuthLink.Click();
            return new BasicAuthPage(Driver);
        }

        public CheckBoxesPage ClickCheckBoxesLink()
        {
            CheckBoxesLink.Click();
            return new CheckBoxesPage(Driver);
        }

        public ContextMenuPage ClickContextMenuLink()
        {
            ContextMenuLink.Click();
            return new ContextMenuPage(Driver);
        }

        public void GoTo(string url)
        {
            Driver.GoTo(url);
        }
    }
}
