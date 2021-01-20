using Psychostasia.Web;
using Psychostasia.Web.Element_Search;
using Psychostasia.Web.ElementClasses;
using System.Collections.ObjectModel;

namespace Sandbox
{
    public class AddRemoveElementPage
    {
        private readonly IDriver driver;
        private readonly string Url = "https://the-internet.herokuapp.com/add_remove_elements/";

        public AddRemoveElementPage(IDriver driver)
        {
            this.driver = driver;
        }

        private IElement AddElementButton => driver.FindElement(Via.XPath("//button[.='Add Element']"));

        private ReadOnlyCollection<IElement> DeleteButtons => driver.FindElements(Via.XPath("//button[@class='added-manually']"));

        public AddRemoveElementPage GoTo()
        {
            driver.GoTo(Url);
            return this;
        }
        
        public AddRemoveElementPage ClickAddElementButton(int clicks = 1)
        {
            for (int i = 0; i < clicks; i++)
            {
                AddElementButton.Click();
            }
            return this;
        }

        public AddRemoveElementPage ClickOnDeleteButton(int index)
        {
            DeleteButtons[index].Click();
            return this;
        }

        public int ReturnDeleteButtonCount()
        {
            return DeleteButtons.Count;
        }
    }
}