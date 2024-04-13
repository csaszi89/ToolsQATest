using OpenQA.Selenium;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Extensions;
using ToolsQA.Tests.Pages;
using ToolsQA.Tests.TestCaseSources;

namespace ToolsQA.Tests.Tests
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
        [TestCaseSource(typeof(TextBoxTestCaseSource), nameof(TextBoxTestCaseSource.FullNamePositiveCases))]
        public void InputFullName_Positive(string value)
        {
            _textBoxPage.InputFullName(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.NameP.Displayed);
        }

        [Test]
        [TestCaseSource(typeof(TextBoxTestCaseSource), nameof(TextBoxTestCaseSource.FullNameNegativeCases))]
        public void InputFullName_Negative(string value)
        {
            _textBoxPage.InputFullName(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.OutputDiv.IsElementPresent(By.Id("name")), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(TextBoxTestCaseSource), nameof(TextBoxTestCaseSource.EmailPositiveCases))]
        public void InputEmail_Positive(string value)
        {
            _textBoxPage.InputEmail(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.EmailP.Displayed);
        }

        [Test]
        [TestCaseSource(typeof(TextBoxTestCaseSource), nameof(TextBoxTestCaseSource.EmailNegativeCases))]
        public void InputEmail_Negative(string value)
        {
            _textBoxPage.InputEmail(value);
            _textBoxPage.ClickSubmitButton();
            Assert.That(_textBoxPage.OutputDiv.IsElementPresent(By.Id("email")), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(TextBoxTestCaseSource), nameof(TextBoxTestCaseSource.FillFormPositiveCases))]
        public void FillForm(TextBoxPageFormData formData)
        {
            _textBoxPage.FillForm(formData);
            Assert.Multiple(() =>
            {
                Assert.That(_textBoxPage.NameP.Displayed);
                Assert.That(_textBoxPage.EmailP.Displayed);
                Assert.That(_textBoxPage.CurrentAddressP.Displayed);
                Assert.That(_textBoxPage.PermanentAddressP.Displayed);
            });
        }
    }
}
