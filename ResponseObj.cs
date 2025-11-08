using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Airport1 data
    /// </summary>
    public class Airport1
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("elevation")]
        public int Elevation { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

    }
    /// <summary>
    /// Airport2 data
    /// </summary>
    public class Airport2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("elevation")]
        public int Elevation { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("distanceMiles")]
        public double DistanceMiles { get; set; }

        [JsonProperty("distanceKm")]
        public double DistanceKm { get; set; }

        [JsonProperty("airport1")]
        public Airport1 Airport1 { get; set; }

        [JsonProperty("airport2")]
        public Airport2 Airport2 { get; set; }

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
