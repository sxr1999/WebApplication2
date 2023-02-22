using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class OptionsList
    {
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; internal set; }

        [JsonProperty(PropertyName = "options")]
        public string Options { get; internal set; }
    }
}
