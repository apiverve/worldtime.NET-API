using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// FoundCities data
    /// </summary>
    public class FoundCities
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_ascii")]
        public string Cityascii { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("time24")]
        public string Time24 { get; set; }

        [JsonProperty("time12")]
        public string Time12 { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("unix")]
        public string Unix { get; set; }

        [JsonProperty("dst")]
        public bool Dst { get; set; }

        [JsonProperty("dst_start")]
        public string Dststart { get; set; }

        [JsonProperty("dst_end")]
        public string Dstend { get; set; }

        [JsonProperty("dst_name")]
        public string Dstname { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("foundCities")]
        public FoundCities[] FoundCities { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
