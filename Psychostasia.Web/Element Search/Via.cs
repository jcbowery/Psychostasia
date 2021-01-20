using OpenQA.Selenium;

namespace Psychostasia.Web.Element_Search
{
    public class Via
    {
        protected Via()
        {
        }

        public static By ClassName(string classNameToFind)
       {
            return By.ClassName(classNameToFind);
       }

        public static By CssSelector(string cssSelectorToFind)
        {
            return By.CssSelector(cssSelectorToFind);
        }
        
        public static By Id(string idToFind)
        {
            return By.Id(idToFind);
        }
       
        public static By LinkText(string linkTextToFind)
        {
            return By.LinkText(linkTextToFind);
        }
        
        public static By Name(string nameToFind)
        {
            return By.Name(nameToFind);
        }
        
        public static By PartialLinkText(string partialLinkTextToFind)
        {
            return By.PartialLinkText(partialLinkTextToFind);
        }
        
        public static By TagName(string tagNameToFind)
        {
            return By.TagName(tagNameToFind);
        }
        
        public static By XPath(string xpathToFind)
        {
            return By.XPath(xpathToFind);
        }
    }
}
