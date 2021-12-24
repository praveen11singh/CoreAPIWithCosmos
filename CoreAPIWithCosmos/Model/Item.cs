using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoreAPIWithCosmos.Model
{
    public class Item
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("isComplete")]
        public bool Completed { get; set; }
    }
}
