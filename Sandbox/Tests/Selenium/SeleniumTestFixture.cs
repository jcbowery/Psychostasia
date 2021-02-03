using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Psychostasia.Web.DriverClasses;

namespace Sandbox
{
    [TestClass]
    public class SeleniumTestFixture
    {

        protected IDriver driver;



        [TestCleanup]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
