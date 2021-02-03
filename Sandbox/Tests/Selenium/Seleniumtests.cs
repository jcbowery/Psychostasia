using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web.Selenium;
using Psychostasia.Web.Selenium.DriverFactory;
using Sandbox.Pages;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace Sandbox
{
    [TestClass]
    public class Seleniumtests : SeleniumTestFixture
    {
        [ClassInitialize]
        public static void ClassStart(TestContext TestContext)
        {
            DriverFactory.SetBrowser("chrome");
        }

        [TestMethod]
        public void Test1()
        {
            string search = "ello";
            driver = new SeleniumDriver(new ChromeDriver());
            driver.GoTo("https://www.google.com");

            GooglePage_Selenium google = new GooglePage_Selenium(driver);
            google.EnterSearch(search);
            var title = google.GetPageTitle();

            Assert.AreEqual($"{search} - Google Search",title);
        }

        
    }
}
