using Newtonsoft.Json;
using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.Utils
{
    internal class JsonReader
    {
        internal static Browser[] GetBrowsers()
        {
            using StreamReader sr = new("browsers.json");
            string json = sr.ReadToEnd();
            var browsers = JsonConvert.DeserializeObject<List<Browser>>(json);

            if (browsers == null)
            {
                throw new InvalidOperationException("Browsers not specified");
            }

            return browsers.ToArray();
        }
    };
}