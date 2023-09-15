using OpenQA.Selenium;
using ToolsQA.Tests.Common;

namespace ToolsQA.Tests.Pages
{
    public class RadioButtonPage : PageBase
    {
        public RadioButtonPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => $"{BaseUrl}/radio-button";
    }
}
