using Psychostasia.Web;
using Psychostasia.Web.Element_Search;
using Psychostasia.Web.ElementClasses;

namespace Sandbox
{
    public class ContextMenuPage
    {
        private readonly IDriver driver;
        private readonly string Url = "https://the-internet.herokuapp.com/context_menu";

        public ContextMenuPage(IDriver driver)
        {
            this.driver = driver;
        }

        private IElement ContextBox => driver.FindElement(Via.Id("hot-spot"));

        public ContextMenuPage RightClickBox()
        {
            ContextBox.RightClick(this.driver);
            return this;
        }

        public string GrabAlertBoxString()
        {
            return driver.GrabAlertText();
        }

        public ContextMenuPage GoTo()
        {
            driver.GoTo(Url);
            return this;
        }
    }
}