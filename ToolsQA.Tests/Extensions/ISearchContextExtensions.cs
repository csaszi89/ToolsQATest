using OpenQA.Selenium;

namespace ToolsQA.Tests.Extensions
{
    internal static class ISearchContextExtensions
    {
        internal static bool TryFindElement(this ISearchContext searchContext, By by, out IWebElement result)
        {
            try
            {
                result = searchContext.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                result = null!;
                return false;
            }
        }

        internal static bool IsElementPresent(this ISearchContext searchContext, By by)
        {
            return searchContext.TryFindElement(by, out _);
        }
    }
}
