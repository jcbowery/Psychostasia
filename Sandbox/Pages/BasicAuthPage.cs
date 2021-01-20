using Psychostasia.Web;
using Psychostasia.Web.Element_Search;
using Psychostasia.Web.ElementClasses;

namespace Sandbox
{
    public class BasicAuthPage
    {
        private readonly string Url = "https://the-internet.herokuapp.com/basic_auth";
        private readonly IDriver driver;

        public BasicAuthPage(IDriver driver)
        {
            this.driver = driver;
        }

        private IElement PassMessage => driver.FindElement(Via.XPath("//p"));

        public BasicAuthPage SignIn(string account, string pass)
        {
            driver.SignIntoAuthWindow(account, pass);
            return this;
        }

        public string SuccessMessage()
        {
            return PassMessage.Text;
        }

        public BasicAuthPage GoTo(string acc, string pass, string url)
        {
            driver.GoTo(acc, pass, url);
            return this;
        }

        public BasicAuthPage GoTo()
        {
            driver.GoTo(Url);
            return this;
        }


    }
}