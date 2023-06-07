using OpenQA.Selenium;

namespace ToolsQA.Tests.Common
{
    public abstract class PageBase
    {
        protected const string BaseUrl = "https://demoqa.com";

        protected readonly IWebDriver _driver;

        protected PageBase(IWebDriver driver)
        {
            _driver = driver;
        }

        protected abstract string Url { get; }

        public virtual void NavigateTo()
        {
            _driver.Navigate().GoToUrl(Url);
        }
    }
}
