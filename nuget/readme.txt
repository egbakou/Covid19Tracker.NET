Covid19Tracker.NET

Find the latest at: https://github.com/egbakou/Covid19Tracker.NET


## Note

Add namespace Covid19Tracker.Services and call Covid19TrackerAPI class to access to all methods.


## Usage

👉 Get latest about total confirmed cases and deaths in the world.
Latest latest = await Covid19Tracker.GetLatestAsync();
// Output
Console.WriteLine("Confirmed: " + latest.Confirmed);
Console.WriteLine("Deaths: " + latest.Deaths);


👉 Get latest related to a specific country based on the country code.
Latest latest = await Covid19Tracker.GetLatestAboutCountryByCodeAsync(string countryCode);
|| Country code example: "IT" for Italy


👉 Gets the Coordinates(Longitude and Latitude), the latest data about the country and the last updated date based on the country code.
Location location = await Covid19Tracker.GetLocationWithDataByCodeAsync(string countryCode);
// Output
Console.WriteLine("Country: " + location.Country);
Console.WriteLine("Longitude: " + location.Longitude);
Console.WriteLine("Latitude: " + location.Latitude.);
Console.WriteLine("Confirmed: " + location.Latest.Confirmed);
Console.WriteLine("Deaths: " + location.Latest.Deaths);
Console.WriteLine("Last updated Date: " + location.LastUpdated);
|| Country code example: "IT" for Italy


👉 Get latest related to a specific country based on the country name.
Latest latest = await Covid19Tracker.GetLatestAboutCountryByNameAsync(string countryName);


👉 Gets the Coordinates(Longitude and Latitude), the latest data about the country and the last updated date based on the country code.
Location location = await Covid19Tracker.GetLocationWithDataByNameAsync(string countryName);
// Output
Console.WriteLine("Country: " + location.Country);
Console.WriteLine("Longitude: " + location.Longitude);
Console.WriteLine("Latitude: " + location.Latitude.);
Console.WriteLine("Confirmed: " + location.Latest.Confirmed);
Console.WriteLine("Deaths: " + location.Latest.Deaths);
Console.WriteLine("Last updated  Date: " + location.LastUpdated);
|| Country name example: "Italy"


👉 Get Data from of all locations in the world (Latest + Locations).
CoronavirusOutbreakData data = await Covid19Tracker.GetTheWorldCovid19Data();


👉 Get all countries data.
List<Location> result = await Covid19Tracker.GetAllCountriesDataAsync();