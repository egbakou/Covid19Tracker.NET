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
        public long Cases { get; set; }

        /// <summary>
        /// Gets or sets the TodayCases.
        /// </summary>
        [JsonProperty("todayCases")]
        public long TodayCases { get; set; }

        /// <summary>
        /// Gets or sets the Deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Gets or sets the TodayDeaths.
        /// </summary>
        [JsonProperty("todayDeaths")]
        public long TodayDeaths { get; set; }

        /// <summary>
        /// Gets or sets the Recovered.
        /// </summary>
        [JsonProperty("recovered")]
        public long Recovered { get; set; }

        /// <summary>
        /// Gets or sets the Active.
        /// </summary>
        [JsonProperty("active")]
        public long Active { get; set; }

        /// <summary>
        /// Gets or sets the Critical.
        /// </summary>
        [JsonProperty("critical")]
        public long Critical { get; set; }


        /// <summary>
        /// Gets or Sets Population.
        /// </summary>
        [JsonProperty("population")]
        public long Population { get; set; }

        /// <summary>
        /// Gets or sets the Tests.
        /// </summary>
        [JsonProperty("tests")]
        public long Tests { get; set; }


        /// <summary>
        /// Gets or sets the Continent.
        /// </summary>
        [JsonProperty("continent")]
        public string Continent { get; set; }
    }
}
