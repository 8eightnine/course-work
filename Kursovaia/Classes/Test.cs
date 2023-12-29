using Newtonsoft.Json;

namespace Kursovaia
{
    public class Test : MedicalHistory
    {
        [JsonProperty("results")]
        public string Results { get; set; }
    }
}
