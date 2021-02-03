using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Protractor;
using Psychostasia.Web.Protractor;
using Psychostasia.Web.Selenium.DriverFactory;
using Sandbox.Pages;
using Sandbox.Tests.Protractor;

//[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace Sandbox.Tests
{
    [TestClass]
    public class ProtractorTests : ProtractorTestFixture
    {
        [ClassInitialize]
        public static void ClassStart(TestContext TestContext)
        {
            DriverFactory.SetBrowser("chrome");
        }

        [TestMethod]
        public void Test1()
        {
            driver = new ProtractorDriver(new NgWebDriver(new ChromeDriver()));
            driver.GoTo("http://juliemr.github.io/protractor-demo/");

            SuperCalculator_Protractor calc = new SuperCalculator_Protractor(driver);

            calc.EnterNumbers(200, 100);
            calc.ClickGoButton();
            var total = calc.GetCalcOutput();

            Assert.AreEqual("300", total);
        }


    }
}
