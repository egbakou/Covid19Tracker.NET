using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Diagnostics;

namespace Covid19Tracker.Helpers
{
    /// <summary>
    /// Custom DateTime JSON serializer/deserializer: see https://blog.kulman.sk/custom-datetime-deserialization-with-json-net/
    /// </summary>
    public class LongToUTCDateTimeConverter : DateTimeConverterBase
    {
        private static readonly DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Writes value to JSON
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Value to be written</param>
        /// <param name="serializer">JSON serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - start).TotalMilliseconds + "000");
        }

        /// <summary>
        /// Reads value from JSON
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Target type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON serialized</param>
        /// <returns>Deserialized DateTime</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            Debug.WriteLine("{VALUE: " + reader.Value + "}");
            return start.AddMilliseconds((long)reader.Value).ToLocalTime();
        }
    }

}
