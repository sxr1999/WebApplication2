using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class Root
    {
        public Root()
        {
            Number = null;
            OptionsList = new List<OptionsList>();
        }

        [JsonProperty(PropertyName = "number")]
        public string Number { get; internal set; }

        [JsonProperty(PropertyName = "optionsList")]
        public List<OptionsList> OptionsList { get; internal set; }
    }
}
