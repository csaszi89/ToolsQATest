using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Utils;

namespace ToolsQA.Tests.Common
{
    [TestFixtureSource(typeof(JsonReader), nameof(JsonReader.GetBrowsers))]
    public class TestBase
    {
        private readonly Browser _browser;

        public TestBase(Browser browser)
        {
            _browser = browser;
        }

        [SetUp]
        public void SetUp()
        {
            Driver = StartBrowser();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }

        protected IWebDriver Driver { get; private set; }

        private static Browser[] FixtureArgs() => JsonReader.GetBrowsers();

        private DriverOptions GetOptions()
        {
            DriverOptions options = _browser.Name switch
            {
                "Chrome" => new ChromeOptions(),
                "MicrosoftEdge" => new EdgeOptions(),
                _ => throw new NotSupportedException($"Browser {_browser.Name} not supported"),
            };
            options.BrowserVersion = _browser.Version;
            return options;
        }

        private IWebDriver StartBrowser()
        {
            return new RemoteWebDriver(new Uri(TestEnvironment.RemoteWebDriverUrl), GetOptions());
        }
    }
}
