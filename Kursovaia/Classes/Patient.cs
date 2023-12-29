using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kursovaia
{
    public class Patient
    {
        [JsonProperty("personalInfo")]
        public PersonalInfo PersonalInfo { get; set; }

        [JsonProperty("appointments")]
        public List<Appointment> Appointments { get; set; }

        [JsonProperty("tests")]
        public List<Test> Tests { get; set; }
    }
}
