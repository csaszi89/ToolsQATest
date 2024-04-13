using OpenQA.Selenium;

namespace ToolsQA.Tests.Extensions
{
    internal static class IWebElementExtensions
    {
        /// <summary>
        /// Performs a click operation using JavaScript executor.
        /// Can be used to avoid <see cref="ElementClickInterceptedException"/>
        /// </summary>
        /// <param name="element">The element to receive the click operation.</param>
        /// <param name="driver">The driver to use to perform the operation.</param>
        internal static void ClickByJavaScript(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", element);
        }
    }
}
