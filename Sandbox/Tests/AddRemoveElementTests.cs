using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web;

namespace Sandbox.Tests
{
    [TestClass]
    public class AddRemoveElementTests
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

        [DataTestMethod]
        [DataRow(1, 0)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(5, 4)]
        public void ClickDeleteButton_OnlyRemovesOneButton(int numberOfButtonsToAdd, int expected)
        {
            var numberOfButtons = new AddRemoveElementPage(Driver).GoTo()
                .ClickAddElementButton(numberOfButtonsToAdd)
                .ClickOnDeleteButton(0)
                .ReturnDeleteButtonCount();
            
            Assert.AreEqual(expected, numberOfButtons);
        }
    }
}
