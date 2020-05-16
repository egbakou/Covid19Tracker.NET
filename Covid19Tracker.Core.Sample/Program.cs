using System;
using System.Threading.Tasks;
using static Covid19Tracker.Services.Covid19TrackerAPI;


namespace Covid19Tracker.Core.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            long unixDate = 1589495874828;
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime date = start.AddMilliseconds(unixDate).ToLocalTime();
            Console.WriteLine(date.ToShortDateString());

            var result1 = await GetContinentsDataAsync();
            Console.WriteLine(result1.Count);
            Console.ReadLine();


        }
    }
}
