using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web;

namespace Sandbox.Tests
{
    [TestClass]
    public class ContextMenuTests
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
        public void ContextMenu_GetCorrectAlert()
        {
            var message = new ContextMenuPage(Driver)
                .GoTo()
                .RightClickBox()
                .GrabAlertBoxString();
            Assert.AreEqual("You selected a context menu", message);
                
        }
    }
}
