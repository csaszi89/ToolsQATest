using Newtonsoft.Json;
using ToolsQA.Tests.Definitions;

namespace ToolsQA.Tests.Utils
{
    internal class JsonReader
    {
        internal static BrowserInfo[] GetBrowserInfo()
        {
            var workingDir = Environment.CurrentDirectory;
            using StreamReader sr = new(Path.Combine(workingDir, "browsers.json"));
            string json = sr.ReadToEnd();
            var browsers = JsonConvert.DeserializeObject<List<BrowserInfo>>(json);
            return browsers == null ? throw new InvalidOperationException("Browsers not specified") : browsers.ToArray();
        }
    };
}