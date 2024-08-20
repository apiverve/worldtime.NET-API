using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class foundCities
{
    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("city_ascii")]
    public string cityascii { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("iso2")]
    public string iso2 { get; set; }

    [JsonProperty("iso3")]
    public string iso3 { get; set; }

    [JsonProperty("province")]
    public string province { get; set; }

    [JsonProperty("timezone")]
    public string timezone { get; set; }

    [JsonProperty("time")]
    public string time { get; set; }

    [JsonProperty("time24")]
    public string time24 { get; set; }

    [JsonProperty("time12")]
    public string time12 { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("day")]
    public string day { get; set; }

    [JsonProperty("month")]
    public string month { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("unix")]
    public string unix { get; set; }

    [JsonProperty("dst")]
    public bool dst { get; set; }

    [JsonProperty("dst_start")]
    public string dststart { get; set; }

    [JsonProperty("dst_end")]
    public string dstend { get; set; }

    [JsonProperty("dst_name")]
    public string dstname { get; set; }

}

public class data
{
    [JsonProperty("search")]
    public string search { get; set; }

    [JsonProperty("foundCities")]
    public foundCities[] foundCities { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
