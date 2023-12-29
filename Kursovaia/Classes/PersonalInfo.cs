using Newtonsoft.Json;
using System;

namespace Kursovaia
{
    public class PersonalInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("fathername")]
        public string Fathername { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }
}
