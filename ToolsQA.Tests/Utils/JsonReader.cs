using Newtonsoft.Json;
using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.Utils
{
    internal class JsonReader
    {
        internal static BrowserInfo[] GetBrowserInfo()
        {
            using StreamReader sr = new("browsers.json");
            string json = sr.ReadToEnd();
            var browsers = JsonConvert.DeserializeObject<List<BrowserInfo>>(json);

            if (browsers == null)
            {
                throw new InvalidOperationException("Browsers not specified");
            }

            return browsers.ToArray();
        }
    };
}