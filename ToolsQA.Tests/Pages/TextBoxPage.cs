﻿using OpenQA.Selenium;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Definitions;
using ToolsQA.Tests.Extensions;

namespace ToolsQA.Tests.Pages
{
    public class TextBoxPage : PageBase
    {
        public TextBoxPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string Url => $"{BaseUrl}/text-box";

        public IWebElement FullNameInput => _driver.FindElement(By.Id("userName"));

        public IWebElement EmailInput => _driver.FindElement(By.Id("userEmail"));

        public IWebElement CurrentAddressTextArea => _driver.FindElement(By.Id("currentAddress"));

        public IWebElement PermanentAddressTextArea => _driver.FindElement(By.Id("permanentAddress"));

        public IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));

        public IWebElement OutputDiv => _driver.FindElement(By.Id("output"));

        public IWebElement NameP => OutputDiv.FindElement(By.Id("name"));

        public IWebElement EmailP => OutputDiv.FindElement(By.Id("email"));

        public IWebElement CurrentAddressP => OutputDiv.FindElement(By.Id("currentAddress"));

        public IWebElement PermanentAddressP => OutputDiv.FindElement(By.Id("permanentAddress"));

        public void InputFullName(string fullName)
        {
            FullNameInput.SendKeys(fullName);
        }

        public void InputEmail(string email)
        {
            EmailInput.SendKeys(email);
        }

        public void InputCurrentAddress(string currentAddress)
        {
            CurrentAddressTextArea.SendKeys(currentAddress);
        }

        public void InputPermanentAddress(string permanentAddress)
        {
            PermanentAddressTextArea.SendKeys(permanentAddress);
        }

        public void ClickSubmitButton()
        {
            SubmitButton.ClickByJavaScript(_driver);
        }

        public void FillForm(TextBoxPageFormData formData)
        {
            InputFullName(formData.FullName);
            InputEmail(formData.Email);
            InputCurrentAddress(formData.CurrentAddress);
            InputPermanentAddress(formData.PermanentAddress);
            ClickSubmitButton();
        }
    }
}
