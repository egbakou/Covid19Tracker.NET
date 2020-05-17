/*
CountryData.cs
14/05/2020 22:59:07
Kodjo Laurent Egbakou
*/

using Covid19Tracker.Helpers;
using Covid19Tracker.Models;
using Newtonsoft.Json;
using System;

namespace Covid19TrackerModels
{
    /// <summary>
    /// Defines a country data class.
    /// </summary>
    public class CountryData
    {
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(LongToUTCDateTimeConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the CountryName.
        /// </summary>
        [JsonProperty("country")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the CountryInfo.
        /// </summary>
        [JsonProperty("countryInfo")]
        public CountryInfo CountryInfo { get; set; }

        /// <summary>
        /// Gets or sets the Cases.
        /// </summary>
        [JsonProperty("cases")]
        public int Cases { get; set; }

        /// <summary>
        /// Gets or sets the TodayCases.
        /// </summary>
        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        /// <summary>
        /// Gets or sets the Deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// Gets or sets the TodayDeaths.
        /// </summary>
        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        /// <summary>
        /// Gets or sets the Recovered.
        /// </summary>
        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        /// <summary>
        /// Gets or sets the Active.
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// Gets or sets the Critical.
        /// </summary>
        [JsonProperty("critical")]
        public int Critical { get; set; }


        /// <summary>
        /// Gets or Sets Population.
        /// </summary>
        [JsonProperty("population")]
        public long Population { get; set; }

        /// <summary>
        /// Gets or sets the Tests.
        /// </summary>
        [JsonProperty("tests")]
        public int Tests { get; set; }


        /// <summary>
        /// Gets or sets the Continent.
        /// </summary>
        [JsonProperty("continent")]
        public string Continent { get; set; }
    }
}
