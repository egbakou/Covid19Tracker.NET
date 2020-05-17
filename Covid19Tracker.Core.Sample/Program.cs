using System;
using System.Threading.Tasks;
using static Covid19Tracker.Services.Covid19TrackerAPI;


namespace Covid19Tracker.Core.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var result1 = await GetContinentsDataAsync();
            //Console.WriteLine(result1.Count);
            //Console.ReadLine();

            //var result2 = await GetDataByContinentAsync("africa");
            //Console.WriteLine(result2.Cases);
            //Console.ReadLine();


            var result3 = await GetCountriesDataAsync();
            Console.WriteLine(result3.Count);
            Console.ReadLine();


            //var result4 = await GetDataByCountryAsync("togo");
            //Console.WriteLine(result4.Cases);
            //Console.ReadLine();


        }
    }
}
