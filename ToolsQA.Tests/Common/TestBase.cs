using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.Common
{
    [TestFixture(BrowserType.Chrome, "latest")]
    [TestFixture(BrowserType.MicrosoftEdge, "latest")]
    [TestFixture(BrowserType.Chrome, "dev")]
    [TestFixture(BrowserType.MicrosoftEdge, "dev")]
    public class TestBase
    {
        private readonly BrowserType _browserType;
        private readonly string _browserVersion;

        public TestBase(BrowserType browserType, string browserVersion)
        {
            _browserType = browserType;
            _browserVersion = browserVersion;
        }

        [SetUp]
        public void SetUp()
        {
            Browser = StartBrowser(_browserType);
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Dispose();
        }

        protected IWebDriver Browser { get; private set; }

        private IWebDriver StartBrowser(BrowserType browserType)
        {
            DriverOptions options;
            switch (browserType)
            {
                case BrowserType.Chrome:
                    options = new ChromeOptions();
                    break;
                case BrowserType.MicrosoftEdge:
                    options = new EdgeOptions();
                    break;
                default:
                    throw new NotSupportedException($"Browser {browserType} not supported");
            }
            options.BrowserVersion = _browserVersion;
            return new RemoteWebDriver(new Uri(TestEnvironment.RemoteWebDriverUrl), options);
        }
    }
}
