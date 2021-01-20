using Psychostasia.Web;

namespace Sandbox
{
    public class ABTestingPage
    {
        private readonly IDriver driver;

        public ABTestingPage(IDriver driver)
        {
            this.driver = driver;
        }
    }
}