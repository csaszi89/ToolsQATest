using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Utils;

namespace ToolsQA.Tests.Common
{
    [TestFixtureSource(nameof(FixtureArgs))]
    public class TestBase
    {
        private static readonly BrowserInfo[] FixtureArgs = JsonReader.GetBrowserInfo();
        private readonly BrowserInfo _browserInfo;

        public TestBase(BrowserInfo browserInfo)
        {
            _browserInfo = browserInfo;
        }

        [SetUp]
        public void SetUp()
        {
            Driver = GetDriver();
            Console.WriteLine($"Browser name: {_browserInfo.Name} - version: {_browserInfo.Version}");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }

        protected IWebDriver Driver { get; private set; }

        private DriverOptions GetOptions()
        {
            DriverOptions options = _browserInfo.Name switch
            {
                "Chrome" => new ChromeOptions(),
                "MicrosoftEdge" => new EdgeOptions(),
                _ => throw new NotSupportedException($"Browser {_browserInfo.Name} not supported"),
            };
            options.BrowserVersion = _browserInfo.Version;
            return options;
        }

        private IWebDriver GetDriver()
        {
            return new RemoteWebDriver(new Uri(TestEnvironment.RemoteWebDriverUrl), GetOptions());
        }
    }
}
