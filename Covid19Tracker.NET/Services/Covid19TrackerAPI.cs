using Covid19Tracker.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static Covid19Tracker.Constants.APIResources;

namespace Covid19Tracker.Services
{
    /// <summary>
    /// A Class consumes an API provided by @ExpDev07(Github) for tracking the global coronavirus (COVID-19, SARS-CoV-2) outbreak.
    /// </summary>
    public class Covid19TrackerAPI
    {
        /// <summary>
        /// Defines a RestClient static object
        /// </summary>
        private static readonly RestClient client = new RestClient(API_BASE_URI);

        /// <summary>
        /// Get latest about total confirmed cases and deaths in the world.
        /// </summary>
        /// <returns>Total confirmed cases and deaths in the world.</returns>
        public static async Task<Latest> GetLatestAsync()
        {
            var request = new RestRequest(
                $"{LATEST_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = (JObject)JsonConvert.DeserializeObject(response.Content);
                var latestNode = jsonObject["latest"];
                return latestNode.ToObject<Latest>();
            }
            throw new Exception("No data found. Please check if https://coronavirus-tracker-api.herokuapp.com/v2/locations is avialable.");
        }

        /// <summary>
        /// Get Coivid-19 data related to a specific country.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns>Total confirmed cases and deaths in the country.</returns>
        public static async Task<Latest> GetLatestAboutCountryByCodeAsync(string countryCode)
        {
            var request = new RestRequest(
                $"{COUNTRYCODE_QUERY_PARAMS}{countryCode.ToUpper()}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                CoronavirusOutbreakData data = jsonObject.ToObject<CoronavirusOutbreakData>();
                if (data.Locations.Count > 0)
                    return data.Latest;
            }
            throw new Exception("No data found. Please, provide the correct country code !");
        }

        /// <summary>
        /// Gets the Location(Longitude and Latitude), the latest
        /// data about the country and the last updated date based on the country code.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns>The Location of the country, his latest covid-19 data and the last updated date.</returns>
        public static async Task<Location> GetLocationWithDataByCodeAsync(string countryCode)
        {
            var request = new RestRequest(
                $"{COUNTRYCODE_QUERY_PARAMS}{countryCode.ToUpper()}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                CoronavirusOutbreakData data = jsonObject.ToObject<CoronavirusOutbreakData>();

                if (data.Locations.Count > 0)
                    return data.Locations.Last();
            }
            throw new Exception("No data found. Please, provide the correct country code !");
        }

        /// <summary>
        /// Get Coivid-19 data related to a specific country.
        /// </summary>
        /// <param name="countryName">The country name.</param>
        /// <returns>Total confirmed cases and deaths in the country.</returns>
        public static async Task<Latest> GetLatestAboutCountryByNameAsync(string countryName)
        {
            var request = new RestRequest(
                $"{LOCATIONS_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                CoronavirusOutbreakData data = jsonObject.ToObject<CoronavirusOutbreakData>();

                //Get the location object using the country code
                var location = data.Locations.Where(l => l.Country.ToLower().Equals(countryName.ToLower()) && l.Province == "")
                    .FirstOrDefault();
                if (location != null)
                    return location.Latest;
            }
            throw new Exception("No data found. Please, provide the correct country name in English language !");
        }

        /// <summary>
        /// Gets the Location(Longitude and Latitude), the latest
        /// data about the country and the last updated date based on the country name.
        /// </summary>
        /// <param name="countryName">The country name.</param>
        /// <returns>The Location of the country, his latest covid-19 data and the last updated date.</returns>
        public static async Task<Location> GetLocationWithDataByNameAsync(string countryName)
        {
            var request = new RestRequest(
                $"{LOCATIONS_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                CoronavirusOutbreakData data = jsonObject.ToObject<CoronavirusOutbreakData>();

                //Get the location object using the country name
                var location = data.Locations.Where(l => l.Country.ToLower().Equals(countryName.ToLower()) && l.Province == "")
                    .FirstOrDefault();
                if (location != null)
                    return location;
            }
            throw new Exception("No data found. Please, provide the correct country name in English language !");
        }


        /// <summary>
        /// Get Data from of all locations in the world.
        /// </summary>
        /// <returns>Date from all location.</returns>
        public static async Task<CoronavirusOutbreakData> GetTheWorldCovid19Data()
        {
            var request = new RestRequest(
                $"{LOCATIONS_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                return jsonObject.ToObject<CoronavirusOutbreakData>();
            }
            throw new Exception("No data found. Please check if https://coronavirus-tracker-api.herokuapp.com/v2/locations is avialable.");
        }


        /// <summary>
        /// Get all countires data.
        /// </summary>
        /// <returns>A list of Location object(Country, Latest data, ... etc).</returns>
        public static async Task<List<Location>> GetAllCountriesDataAsync()
        {
            var covid19Data = await GetTheWorldCovid19Data();
            return covid19Data.Locations.Where(l => l.Province == "").ToList();
        }

    }
}
