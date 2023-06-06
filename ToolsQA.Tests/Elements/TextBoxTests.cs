using OpenQA.Selenium;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.Elements
{
    public class TextBoxTests : TestBase
    {
        public TextBoxTests(BrowserType browserType, string browserVersion) : base(browserType, browserVersion)
        {
        }

        [SetUp]
        public void TextBoxTestsSetUp()
        {
            Browser.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [Test]
        [TestCase("John Smith")]
        [TestCase("Jane Smith")]
        public void InputFullName(string value)
        {
            var input = Browser.FindElement(By.Id("userName"));
            input.SendKeys(value);
            var submit = Browser.FindElement(By.Id("submit"));
            submit.Click();
            var name = Browser.FindElement(By.Id("name"));
            Assert.IsTrue(name.Text.Contains(value));
        }
    }
}
