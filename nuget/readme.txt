Covid19Tracker.NET V2.0

Find the latest at: https://github.com/egbakou/Covid19Tracker.NET


## Note

Add namespace Covid19Tracker.Services and call
Covid19TrackerAPI class to access to all methods.


## Usage

👉 Gets global stats: cases, deaths, recovered,
time last updated, and active cases. Data is updated every 10 minutes.

```csharp
GlobalData data = await Covid19Tracker.GetGlobalDataAsync();
```

👉  Gets All Continent's Totals

```csharp
List<ContinentData> data = await Covid19Tracker.GetContinentsDataAsync();
```

👉 Gets a Specific Continent Totals.

```csharp
ContinentData data = await Covid19Tracker.GetDataByContinentAsync(string contient);
```

> continent name can be: "Asia", "North America", "South America", Europe", "Africa", "Australia/Oceania"

👉  Gets all Countries Totals

```csharp
List<CountryData> data = await Covid19Tracker.GetCountriesDataAsync();
```

👉  Get a Specific Country's Totals for Actual

```csharp
CountryData data = await Covid19Tracker.GetDataByCountryAsync(string country);
```

> Country name example: "Italy"