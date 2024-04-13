using OpenQA.Selenium;

namespace ToolsQA.Tests.Extensions
{
    internal static class IWebElementExtensions
    {
        internal static void ClickByJavaScript(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }
    }
}
