using System.Collections.Generic;
using Newtonsoft.Json;
namespace Covid19Feeds.Models
{
    public class StateDistrictDataModel
    {

        [JsonProperty("state")]
        public string state { get; set; }

        [JsonProperty("districtData")]
        public IEnumerable<DistrictData> districtData { get; set; }
    }



    public class Delta
    {

        [JsonProperty("confirmed")]
        public int confirmed { get; set; }
    }

    public class DistrictData
    {

        [JsonProperty("district")]
        public string district { get; set; }

        [JsonProperty("confirmed")]
        public int confirmed { get; set; }

        [JsonProperty("lastupdatedtime")]
        public string lastupdatedtime { get; set; }

        [JsonProperty("delta")]
        public Delta delta { get; set; }
    }

   

}
