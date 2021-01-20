using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web;
using System.Threading;

namespace Sandbox
{
    [TestClass]
    public class InternetHomeTests
    {
        private IDriver Driver;
        
        [TestInitialize]
        public void BeforeEachTest()
        {
            Driver = new Driver(new ChromeDriver());
        }
        
        [TestCleanup]
        public void AfterEachTest()
        {
            Driver.Quit();
        }

        [TestMethod]
        public void MessingWithDriver()
        {
            var Home = new InternetHomePage(Driver);
            Home.GoTo("https://the-internet.herokuapp.com/");
            Home.ClickAddRemoveLementLink();
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}
