using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Pages;

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
        [TestCase("This is a very long full name just like people have in brasil")]
        public void InputFullName(string value)
        {
            var textBoxPage = new TextBoxPage(Browser);
            textBoxPage.InputFullName(value);
            textBoxPage.ClickSubmitButton();
            Assert.IsTrue(textBoxPage.NameP.Displayed);
        }
    }
}
