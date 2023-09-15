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
        public void CheckBoxTestsSetUp()
        {
            _checkBoxPage = new CheckBoxPage(Driver);
            _checkBoxPage.NavigateTo();
        }

        [Test]
        public void ToggleHomeCheckBox()
        {
            _checkBoxPage.ToggleHomeCheckBox();
            Assert.Multiple(() =>
            {
                Assert.That(_checkBoxPage.IsResultPresent("home"));
                Assert.That(_checkBoxPage.IsResultPresent("desktop"));
                Assert.That(_checkBoxPage.IsResultPresent("notes"));
                Assert.That(_checkBoxPage.IsResultPresent("commands"));
                Assert.That(_checkBoxPage.IsResultPresent("documents"));
                Assert.That(_checkBoxPage.IsResultPresent("workspace"));
                Assert.That(_checkBoxPage.IsResultPresent("documents"));
                Assert.That(_checkBoxPage.IsResultPresent("react"));
                Assert.That(_checkBoxPage.IsResultPresent("angular"));
                Assert.That(_checkBoxPage.IsResultPresent("veu"));
                Assert.That(_checkBoxPage.IsResultPresent("office"));
                Assert.That(_checkBoxPage.IsResultPresent("public"));
                Assert.That(_checkBoxPage.IsResultPresent("private"));
                Assert.That(_checkBoxPage.IsResultPresent("classified"));
                Assert.That(_checkBoxPage.IsResultPresent("general"));
                Assert.That(_checkBoxPage.IsResultPresent("downloads"));
                Assert.That(_checkBoxPage.IsResultPresent("wordFile"));
                Assert.That(_checkBoxPage.IsResultPresent("excelFile"));
            });
        }
    }
}
