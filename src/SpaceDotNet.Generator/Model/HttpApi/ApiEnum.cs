using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiEnum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
        
        [JsonPropertyName("deprecation")]
        public ApiDeprecation? Deprecation { get; set; } = default;
        
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
        
        [JsonPropertyName("values")]
        public List<string> Values { get; set; } = new List<string>();
    }
}