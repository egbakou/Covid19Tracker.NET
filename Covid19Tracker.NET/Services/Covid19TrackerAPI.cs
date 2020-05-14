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
    /// A Class consumes an API provided by @NovelCOVID (Github) for tracking the global coronavirus (COVID-19, SARS-CoV-2) outbreak.
    /// </summary>
    public class Covid19TrackerAPI
    {
        /// <summary>
        /// Defines a RestClient static object
        /// </summary>
        private static readonly RestClient client = new RestClient(API_BASE_URI);

        
       

    }
}
