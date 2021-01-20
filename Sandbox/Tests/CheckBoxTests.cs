using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Psychostasia.Web;

namespace Sandbox.Tests
{
    [TestClass]
    public class CheckBoxTests
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
        public void CheckBox1_ChecksBox()
        {
            var isChecked = new CheckBoxesPage(Driver)
                .GoTo()
                .ClickCheckBox1()
                .Check1IsSelected();
            Assert.IsTrue(isChecked);
        }

        [TestMethod]
        public void CheckBox2_UnchecksBox()
        {
            var isChecked = new CheckBoxesPage(Driver)
                .GoTo()
                .ClickCheckBox2()
                .Check2IsSelected();
            Assert.IsFalse(isChecked);
        }
    }
}
