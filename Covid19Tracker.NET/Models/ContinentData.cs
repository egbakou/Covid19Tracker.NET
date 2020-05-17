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
        [JsonConverter(typeof(LongToUTCDateTimeConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the cases.
        /// </summary>
        [JsonProperty("cases")]
        public long Cases { get; set; }

        /// <summary>
        /// Gets or sets the todayCases.
        /// </summary>
        [JsonProperty("todayCases")]
        public long TodayCases { get; set; }

        /// <summary>
        /// Gets or sets the deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Gets or sets the todayDeaths.
        /// </summary>
        [JsonProperty("todayDeaths")]
        public long DodayDeaths { get; set; }

        /// <summary>
        /// Gets or sets the recovered.
        /// </summary>
        [JsonProperty("recovered")]
        public long Recovered { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// </summary>
        [JsonProperty("active")]
        public long Active { get; set; }

        /// <summary>
        /// Gets or sets the critical.
        /// </summary>
        [JsonProperty("critical")]
        public long Critical { get; set; }

        /// <summary>
        /// Gets or sets the continent.
        /// </summary>
        [JsonProperty("continent")]
        public string ContinentName { get; set; }

       
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
        /// Gets or sets the countries.
        /// </summary>
        [JsonProperty("countries")]
        public IList<string> Countries { get; set; }
    }
}
