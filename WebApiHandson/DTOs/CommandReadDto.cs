using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHandson.DTOs
{
    public class CommandReadDto
    {
        [JsonProperty("Id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }

    }
}
