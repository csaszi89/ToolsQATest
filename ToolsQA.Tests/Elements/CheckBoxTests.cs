using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests.Elements
{
    public class CheckBoxTests : TestBase
    {
        private CheckBoxPage _checkBoxPage;

        public CheckBoxTests(BrowserInfo browserInfo) : base(browserInfo)
        {
        }

        [SetUp]
        public void TextBoxTestsSetUp()
        {
            _checkBoxPage = new CheckBoxPage(Driver);
            _checkBoxPage.NavigateTo();
        }

        [Test]
        public void ToggleHomeCheckBox()
        {
            _checkBoxPage.ToggleHomeCheckBox();
            Assert.That(_checkBoxPage.IsResultPresent("home"));
        }
    }
}
