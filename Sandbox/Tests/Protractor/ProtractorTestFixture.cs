using Microsoft.VisualStudio.TestTools.UnitTesting;
using Psychostasia.Web.DriverClasses;

namespace Sandbox.Tests.Protractor
{
    [TestClass]
    public class ProtractorTestFixture
    {
        protected IDriver driver;

        [TestCleanup]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
