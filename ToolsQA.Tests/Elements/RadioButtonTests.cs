using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Pages;

namespace ToolsQA.Tests.Elements
{
    internal class RadioButtonTests : TestBase
    {
        private RadioButtonPage _radioButtonPage;

        public RadioButtonTests(BrowserInfo browserInfo) : base(browserInfo)
        {
        }

        [SetUp]
        public void RadioButtonTestsSetUp()
        {
            _radioButtonPage = new RadioButtonPage(Driver);
            _radioButtonPage.NavigateTo();
        }
    }
}
