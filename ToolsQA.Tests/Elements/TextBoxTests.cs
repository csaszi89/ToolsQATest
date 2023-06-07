using OpenQA.Selenium;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Extensions;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests.Elements
{
    public class TextBoxTests : TestBase
    {
        private TextBoxPage _textBoxPage;

        public TextBoxTests(BrowserInfo browser) : base(browser)
        {
        }

        [SetUp]
        public void TextBoxTestsSetUp()
        {
            _textBoxPage = new TextBoxPage(Driver);
            _textBoxPage.NavigateTo();
        }

        [Test]
        [TestCase("")]
        public void InputFullName_Negative(string value)
        {
            _textBoxPage.InputFullName(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.OutputDiv.IsElementPresent(By.Id("name")), Is.False);
        }

        [Test]
        [TestCase("John Smith")]
        [TestCase("Jane Smith")]
        [TestCase("This is a very long full name just like people have in brasil")]
        public void InputFullName_Positive(string value)
        {
            _textBoxPage.InputFullName(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.NameP.Displayed);
        }

        [Test]
        [TestCase("")]
        [TestCase("invalidemail.com")]
        [TestCase("invalid@emailcom")]
        public void InputEmail_Negative(string value)
        {
            _textBoxPage.InputEmail(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.OutputDiv.IsElementPresent(By.Id("email")), Is.False);
        }

        [Test]
        [TestCase("valid@email.com")]
        public void InputEmail_Positive(string value)
        {
            _textBoxPage.InputEmail(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.EmailP.Displayed);
        }
    }
}
