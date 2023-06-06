using OpenQA.Selenium;

namespace ToolsQA.Tests.Common
{
    public abstract class PageBase
    {
        protected readonly IWebDriver _driver;

        protected PageBase(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
