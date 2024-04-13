namespace ToolsQA.Tests.Definitions
{
    public readonly struct TextBoxPageFormData
    {
        public TextBoxPageFormData(string fullName, string email, string currentAddress, string permanentAddress)
        {
            FullName = fullName;
            Email = email;
            CurrentAddress = currentAddress;
            PermanentAddress = permanentAddress;
        }

        public string FullName { get; }
        public string Email { get; }
        public string CurrentAddress { get; }
        public string PermanentAddress { get; }
    }
}
