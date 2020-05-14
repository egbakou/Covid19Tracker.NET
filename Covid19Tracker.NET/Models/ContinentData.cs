/*
Continent.cs
14/05/2020 22:46:22
Kodjo Laurent Egbakou
*/

using Covid19Tracker.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines a continent data class.
    /// </summary>
    public class ContinentData
    {
        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the cases.
        /// </summary>
        [JsonProperty("cases")]
        public int Cases { get; set; }

        /// <summary>
        /// Gets or sets the todayCases.
        /// </summary>
        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        /// <summary>
        /// Gets or sets the deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public int deaths { get; set; }

        /// <summary>
        /// Gets or sets the todayDeaths.
        /// </summary>
        [JsonProperty("todayDeaths")]
        public int DodayDeaths { get; set; }

        /// <summary>
        /// Gets or sets the recovered.
        /// </summary>
        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// Gets or sets the critical.
        /// </summary>
        [JsonProperty("critical")]
        public int Critical { get; set; }

        /// <summary>
        /// Gets or sets the continent.
        /// </summary>
        [JsonProperty("continent")]
        public string ContinentName { get; set; }

        /// <summary>
        /// Gets or sets the countries.
        /// </summary>
        [JsonProperty("countries")]
        public IList<string> Countries { get; set; }
    }
}
