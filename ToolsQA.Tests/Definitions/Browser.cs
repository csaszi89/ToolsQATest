using Newtonsoft.Json;

namespace ToolsQA.Tests.Definitions
{
    public class Browser
    {
        [JsonProperty("browserName")]
        public string? Name { get; set; }

        [JsonProperty("browserVersion")]
        public string? Version { get; set; }
    }
}
