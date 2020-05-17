using Covid19Tracker.Models;
using Covid19TrackerModels;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using static Covid19Tracker.Constants.APIResources;

namespace Covid19Tracker.Services
{
    /// <summary>
    /// A Class consumes an API provided by @NovelCOVID (Github) for tracking the global coronavirus (COVID-19, SARS-CoV-2) outbreak.
    /// </summary>
    public class Covid19TrackerAPI
    {
        /// <summary>
        /// Defines a RestClient static object..
        /// </summary>
        private static readonly RestClient client = new RestClient(API_BASE_URI);

        /// <summary>
        /// Get global stats: cases, deaths, recovered, time last updated, and active cases. Data is updated every 10 minutes.
        /// </summary>
        /// <returns>Global Totals for Actual and Yesterday Data.</returns>
        public static async Task<WorlData> GetWorlDataAsync()
        {
            var request = new RestRequest(
                $"{ALL_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                return jsonObject.ToObject<WorlData>();
            }
            throw new Exception("No data found. Please check if https://disease.sh is avialable.");
        }

        /// <summary>
        /// Get All Continents Totals for Actual and Yesterday Data.
        /// </summary>
        /// <returns>A List with an element for each continent that has stats available.</returns>
        public static async Task<List<ContinentData>> GetContinentsDataAsync()
        {
            var request = new RestRequest(
                $"{CONTINENTS_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<ContinentData>>();
            }
            throw new Exception("No data found. Please check if https://disease.sh is avialable.");
        }

        /// <summary>
        /// Get a Specific Continent Totals for Actual and Yesterday Data.
        /// </summary>
        /// <param name="continent">The continent name (in English)</param>
        /// <returns>The continent data.</returns>
        public static async Task<ContinentData> GetDataByContinentAsync(string continent)
        {
            var request = new RestRequest(
                $"{CONTINENTS_ENDPOINT}/{continent}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                return jsonObject.ToObject<ContinentData>();
            }
            throw new Exception("Continent not found or doesn't have any cases");
        }

        /// <summary>
        /// Get All Countries Totals for Actual and Yesterday Data.
        /// </summary>
        /// <returns>a List with of an element for each country that has stats available. 
        /// This includes iso codes, lat/long, a link to the country flag, cases, new cases,
        /// deaths, new deaths, recovered, active cases, critical cases, and cases/deaths
        /// per one million people. Data is updated every 10 minutes.</returns>
        public static async Task<List<CountryData>> GetCountriesDataAsync()
        {
            var request = new RestRequest(
                $"{COUNTRIES_ENDPOINT}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<CountryData>>();
            }
            throw new Exception("No data found. Please check if https://disease.sh is avialable.");
        }

        /// <summary>
        /// Get a Specific Country's Totals for Actual and Yesterday Data.s
        /// </summary>
        /// <param name="country">The country name (in English)</param>
        /// <returns>Country data</returns>
        public static async Task<CountryData> GetDataByCountryAsync(string country)
        {
            var request = new RestRequest(
                $"{COUNTRIES_ENDPOINT}/{country}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetAsync(request).ConfigureAwait(false);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                return jsonObject.ToObject<CountryData>();
            }
            throw new Exception("Country not found or doesn't have any cases");
        }
    }
}
