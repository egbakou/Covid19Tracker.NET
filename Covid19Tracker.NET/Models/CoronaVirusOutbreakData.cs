using Newtonsoft.Json;
using System.Collections.Generic;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines the Covid-19 data.
    /// </summary>
    public class CoronavirusOutbreakData
    {
        /// <summary>
        /// Gets or sets the Latest.
        /// </summary>
        [JsonProperty("latest")]
        public Latest Latest { get; set; }

        /// <summary>
        /// Gets or sets the Locations.
        /// </summary>
        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }
    }
}
