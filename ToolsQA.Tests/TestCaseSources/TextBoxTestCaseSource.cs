using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.TestCaseSources
{
    internal class TextBoxTestCaseSource
    {
        internal static TextBoxPageFormData[] FillFormPositiveCases()
        {
            return new TextBoxPageFormData[]
            {
                new("John Smith", "johnsmith@email.com", "1234 MyCity, MyStreet 1", "4321 AnotherCity, AnotherStreet 1" ),
                new("Jane Smith", "janesmith@email.com", "1234 MyCity, MyStreet 2", "4321 AnotherCity, AnotherStreet 2" )
            };
        }

        internal static string[] FullNamePositiveCases()
        {
            return new string[]
            {
                "John Smith",
                "Jane Smith",
                "András Horváth",
                "Salvador Felipe Jacinto Dalí y Domenech",
                "Tarquin Fin-tim-lin-bin-whin-bim-lim-bus-stop-F’tang-F’tang-Olé-Biscuitbarrel"
            };
        }

        internal static string[] FullNameNegativeCases()
        {
            return new string[]
            {
                string.Empty
            };
        }

        internal static string[] EmailPositiveCases()
        {
            return new string[]
            {
                "john.smith@email.com",
                "jane.smith@email.com"
            };
        }

        internal static string[] EmailNegativeCases()
        {
            return new string[]
            {
                string.Empty,
                "invalidemail.com",
                "invalid@emailcom"
            };
        }
    }
}
