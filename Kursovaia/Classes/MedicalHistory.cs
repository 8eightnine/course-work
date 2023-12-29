using Newtonsoft.Json;
using System;

namespace Kursovaia
{
    public abstract class MedicalHistory
    {
        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
