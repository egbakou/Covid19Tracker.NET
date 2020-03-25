using Newtonsoft.Json;

namespace Covid19Tracker.Models
{
    /// <summary>
    /// Defines the latest data.
    /// </summary>
    public class Latest
    {
        /// <summary>
        /// Gets or sets the total of confirmed cases.
        /// </summary>
        [JsonProperty("confirmed")]
        public long Confirmed { get; set; }

        /// <summary>
        /// Gets or sets the total of deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public long Deaths { get; set; }
    }
}
