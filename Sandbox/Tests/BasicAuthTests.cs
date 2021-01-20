using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web;

namespace Sandbox.Tests
{
    [TestClass]
    public class BasicAuthTests
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
        public void ReceivePropperMessageAfterLoggingIn()
        {
            var message = new BasicAuthPage(Driver)
                .GoTo("admin", "admin", "the-internet.herokuapp.com/basic_auth")
                .SuccessMessage();
                
            Assert.AreEqual("Congratulations! You must have the proper credentials.", message);
        }

    }
}
