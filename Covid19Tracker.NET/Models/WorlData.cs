/*
WorlData.cs
14/05/2020 23:45:33
Kodjo Laurent Egbakou
*/

using Covid19Tracker.Helpers;
using Newtonsoft.Json;
using System;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines the <see cref="WorlData" />.
    /// </summary>
    public class WorlData
    {
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime Updated { get; set; }

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
        /// Gets or sets the CasesPerOneMillion.
        /// </summary>
        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        /// <summary>
        /// Gets or sets the DeathsPerOneMillion.
        /// </summary>
        [JsonProperty("deathsPerOneMillion")]
        public int DeathsPerOneMillion { get; set; }

        /// <summary>
        /// Gets or sets the Tests.
        /// </summary>
        [JsonProperty("tests")]
        public int Tests { get; set; }

        /// <summary>
        /// Gets or sets the TestsPerOneMillion.
        /// </summary>
        [JsonProperty("testsPerOneMillion")]
        public double TestsPerOneMillion { get; set; }

        /// <summary>
        /// Gets or sets the AffectedCountries.
        /// </summary>
        [JsonProperty("affectedCountries")]
        public int AffectedCountries { get; set; }
    }
}
