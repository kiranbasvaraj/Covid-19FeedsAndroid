using System;
using Newtonsoft.Json;

namespace Covid19Feeds.Models
{
   
    public class CountryInfo
    {
        public int? _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public double? lat { get; set; }
        public double? @long { get; set; }
        public string flag { get; set; }
    }

    public class AllCountriesCasesModel
    {    [JsonIgnore]
        public object updated { get; set; }
        public string country { get; set; }
        public CountryInfo countryInfo { get; set; }
        public int? cases { get; set; }
        public int? todayCases { get; set; }
        public int? deaths { get; set; }
        public int? todayDeaths { get; set; }
        public int? recovered { get; set; }
        public int? active { get; set; }
        public int? critical { get; set; }
        public int? casesPerOneMillion { get; set; }
        public int? deathsPerOneMillion { get; set; }
        public int? tests { get; set; }
        public int? testsPerOneMillion { get; set; }

        [JsonIgnore]
        public string StartColor { get; set; }
        [JsonIgnore]
        public string EndColor { get; set; }

    }
}
