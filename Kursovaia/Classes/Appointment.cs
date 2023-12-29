using Newtonsoft.Json;

namespace Kursovaia
{
    public class Appointment : MedicalHistory
    {
        [JsonProperty("status")]
        public bool Status {  get; set; }
    }
}
