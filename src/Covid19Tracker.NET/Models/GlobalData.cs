using Covid19Tracker.Helpers;
using Newtonsoft.Json;
using System;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines the <see cref="GlobalData" />.
    /// </summary>
    public class GlobalData
    {
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(LongToUTCDateTimeConverter))]
        public DateTime Updated { get; set; }

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
        /// Gets or sets the AffectedCountries.
        /// </summary>
        [JsonProperty("affectedCountries")]
        public int AffectedCountries { get; set; }
    }
}
