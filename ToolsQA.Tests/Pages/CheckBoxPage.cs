using OpenQA.Selenium;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Extensions;

namespace ToolsQA.Tests.Pages
{
    public class CheckBoxPage : PageBase
    {
        public CheckBoxPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => $"{BaseUrl}/checkbox";

        private IWebElement CheckBoxTree => _driver.FindElement(By.Id("tree-node"));

        private IWebElement HomeListItem => CheckBoxTree.FindElement(By.XPath("ol/li"));

        private IWebElement HomeExpandCollapseButton => HomeListItem.FindElement(By.XPath("span/button"));

        private IWebElement HomeCheckBox => HomeListItem.FindElement(By.Id("tree-node-home"));

        private IWebElement ResultDiv => _driver.FindElement(By.Id("result"));

        public void ToggleHomeExpandCollapseButton()
        {
            HomeExpandCollapseButton.Click();
        }

        public void ToggleHomeCheckBox()
        {
            var executor = (IJavaScriptExecutor)_driver;
            executor.ExecuteScript("arguments[0].click();", HomeCheckBox);
        }

        public bool IsResultPresent(string text)
        {
            return ResultDiv.IsElementPresent(By.XPath($"span[text()='{text}']"));
        }
    }
}
