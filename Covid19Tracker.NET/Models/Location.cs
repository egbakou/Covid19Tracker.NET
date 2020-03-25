using Newtonsoft.Json;
using System;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines a country(or a location in a country) with Covid-19 data.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country Code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        //[JsonProperty("id")]
        //public long Id { get; set; }

        /// <summary>
        /// Gets or sets the last updated date.
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the latest data about the location.
        /// </summary>
        [JsonProperty("latest")]
        public Latest Latest { get; set; }

        /// <summary>
        /// Gets or sets the province.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
