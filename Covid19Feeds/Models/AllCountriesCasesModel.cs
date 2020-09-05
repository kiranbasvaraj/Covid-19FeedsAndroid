using System;
using Newtonsoft.Json;

namespace Covid19Feeds.Models
{
   
    public class CountryInfo
    {
        public string _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
        public string flag { get; set; }


    }

    public class AllCountriesCasesModel
    {    [JsonIgnore]
        public object updated { get; set; }
        public string country { get; set; }
        public CountryInfo countryInfo { get; set; }
        public string cases { get; set; }
        public string todayCases { get; set; }
        public string deaths { get; set; }
        public string todayDeaths { get; set; }
        public string recovered { get; set; }
        public string active { get; set; }
        public string critical { get; set; }
        public string casesPerOneMillion { get; set; }
        public string deathsPerOneMillion { get; set; }
        public string tests { get; set; }
        public string testsPerOneMillion { get; set; }
        public string population { get; set; }
        public string continent { get; set; }
        public string oneCasePerPeople { get; set; }
        public string oneDeathPerPeople { get; set; }
        public string oneTestPerPeople { get; set; }
        public string activePerOneMillion { get; set; }
        public string recoveredPerOneMillion { get; set; }
        public string criticalPerOneMillion { get; set; }

        [JsonIgnore]
        public string StartColor { get; set; }
        [JsonIgnore]
        public string EndColor { get; set; }

    }
}
