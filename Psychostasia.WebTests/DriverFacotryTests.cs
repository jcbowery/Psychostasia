namespace Psychostasia.WebTests
{
    using NUnit.Framework;
    using Psychostasia.Web.DriverFactory;

    public class DriverFactoryTests
    {
        [SetUp]
        public void Setup()
        {
            // Method intentionally left empty.
        }

        [Test]
        public void AddIncognito_Chrome_HasIncognitoArgument()
        {
            var df = new DriverFactory(Browsers.Chrome);

            df.AddIncognito();
            Assert.IsTrue(df.ChromeOptions.Arguments.Contains("--incognito"));
        }

        [Test]
        [Ignore("not sure how to verify firefox arguments")]
        public void AddIncognito_Firefox_HasPrivateArgument()
        {
            var df = new DriverFactory(Browsers.Firefox);

            df.AddIncognito();
            Assert.IsTrue(true);
        }

        [Test]
        public void AddHeadless_Chrome_HasheadlessArgument()
        {
            var df = new DriverFactory(Browsers.Chrome);

            df.AddHeadless();
            Assert.IsTrue(df.ChromeOptions.Arguments.Contains("--headless"));
        }

        [Test]
        [Ignore("not sure how tov erify firefox arguments")]
        public void AddHeadless_Firefox_HasheadlessArgument()
        {
            var df = new DriverFactory(Browsers.Firefox);

            df.AddHeadless();
            Assert.IsTrue(true);
        }

        [TestCase(Browsers.Firefox, "OpenQA.Selenium.Firefox.FirefoxDriver")]
        [TestCase(Browsers.Chrome, "OpenQA.Selenium.Chrome.ChromeDriver")]
        public void Build_Chrome_GivesChromeDriver(Browsers browser, string expected)
        {
            var df = new DriverFactory(browser);

            var driver = df.Build();
            var actual = driver.GetType().FullName;
            driver.Dispose();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(Browsers.Chrome)]
        [TestCase(Browsers.Firefox)]
        public void Sandbox(Browsers browser)
        {
            var df = new DriverFactory(browser);
            df.AddHeadless();

            var driver = df.Build();
            driver.Dispose();
            Assert.IsTrue(true);
        }
    }
}
