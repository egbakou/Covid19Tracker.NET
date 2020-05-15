using System;
using System.Threading.Tasks;
using static Covid19Tracker.Services.Covid19TrackerAPI;


namespace Covid19Tracker.Core.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result1 = await GetCountriesDataAsync();
            Console.WriteLine(result1.Count);
            Console.ReadLine();


        }
    }
}
