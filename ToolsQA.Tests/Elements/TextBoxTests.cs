using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests.Elements
{
    public class TextBoxTests : TestBase
    {
        private TextBoxPage _textBoxPage;

        public TextBoxTests(BrowserType browserType, string browserVersion) : base(browserType, browserVersion)
        {
        }

        [SetUp]
        public void TextBoxTestsSetUp()
        {
            _textBoxPage = new TextBoxPage(Browser);
            _textBoxPage.NavigateTo();
        }

        [Test]
        [TestCase("John Smith")]
        [TestCase("Jane Smith")]
        [TestCase("This is a very long full name just like people have in brasil")]
        public void InputFullName(string value)
        {
            _textBoxPage.InputFullName(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.NameP.Displayed);
        }
    }
}
