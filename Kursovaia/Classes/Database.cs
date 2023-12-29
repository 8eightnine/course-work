using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kursovaia
{
    public class Database
    {
        [JsonProperty("patients")]
        public List<Patient> Patients;
    }
}
