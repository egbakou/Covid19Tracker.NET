# <img src="art/icon.png" alt="Icon" width="60" />Covid19Tracker.NET  v2.0.2
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-2-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

This is a .NET wrapper library around the API provided by [@NovelCovid](https://github.com/NovelCovid/) https://github.com/NovelCovid/API for tracking the global coronavirus (COVID-19, SARS-CoV-2) outbreak. 

It provides up-to-date data about Coronavirus outbreak includes confirmed cases, recovered, deaths, active, today cases, today deaths, tests and more.

![](https://github.com/egbakou/Covid19Tracker.NET/workflows/CI/badge.svg) ![CD](https://github.com/egbakou/Covid19Tracker.NET/workflows/CD/badge.svg) [![NuGet](https://img.shields.io/nuget/v/Covid19Tracker.NET.svg?label=NuGet)](https://www.nuget.org/packages/Covid19Tracker.NET/)

The version 1.0.0 doc is located [here](https://github.com/egbakou/Covid19Tracker.NET/blob/master/Docs/V1.0.0README.md).

## Setup

- Available on NuGet: https://www.nuget.org/packages/Covid19Tracker.NET/ 
- Install into your .NET project(.NET Standard, .NET Core, Xamarin, etc).

## Note

Add `namespace` `Covid19Tracker.Services` and call `Covid19TrackerAPI` class to access to all methods.

## Usage

- Gets global stats. Data is updated every 10 minutes.

```csharp
GlobalData data = await Covid19Tracker.GetGlobalDataAsync();
```

-  Gets All Continent's Totals

```csharp
List<ContinentData> data = await Covid19Tracker.GetContinentsDataAsync();
```

- Gets a Specific Continent Totals.

```csharp
ContinentData data = await Covid19Tracker.GetDataByContinentAsync(string contient);
```

> Continent name: "Asia", "North America", "South America", Europe", "Africa", "Australia/Oceania"

-  Gets all Countries Totals

```csharp
List<CountryData> data = await Covid19Tracker.GetCountriesDataAsync();
```

-  Get a Specific Country's Totals for Actual

```csharp
CountryData data = await Covid19Tracker.GetDataByCountryAsync(string country);
```

> Country name example: "Italy"

- Classes

```csharp
public class GlobalData
{
    // Gets or sets the Updated.
    public DateTime Updated { get; set; }

    // Gets or sets the Cases.
    public long Cases { get; set; }

    // Gets or sets the TodayCases.
    public long TodayCases { get; set; }

    // Gets or sets the Deaths.
    public long Deaths { get; set; }

    // Gets or sets the TodayDeaths.
    public long TodayDeaths { get; set; }

    // Gets or sets the Recovered.
    public long Recovered { get; set; }

    // Gets or sets the Active.
    public long Active { get; set; }

    // Gets or sets the Critical.
    public long Critical { get; set; }

    // Gets or Sets Population.
    public long Population { get; set; }

    // Gets or sets the Tests.
    public long Tests { get; set; }

    // Gets or sets the AffectedCountries.
    public int AffectedCountries { get; set; }      
}
```

```csharp
public class ContientData
{
    // Gets or sets the updated.
    public DateTime Updated { get; set; }

    // Gets or sets the cases.
    public long Cases { get; set; }

    // Gets or sets the todayCases.
    public long TodayCases { get; set; }

    // Gets or sets the deaths.
    public long Deaths { get; set; }

    // Gets or sets the todayDeaths.
    public long DodayDeaths { get; set; }

    // Gets or sets the recovered.
    public long Recovered { get; set; }

    // Gets or sets the active.
    public long Active { get; set; }

    // Gets or sets the critical.
    public long Critical { get; set; }

    // Gets or sets the continent.
    public string ContinentName { get; set; }
       
    // Gets or Sets Population.
    public long Population { get; set; }
    
    // Gets or sets the Tests.
    public long Tests { get; set; }

    // Gets or sets the countries.
    public IList<string> Countries { get; set; }
}
```

```csharp
public class ContientData
{
    // Gets or sets the updated.
    public DateTime Updated { get; set; }

    // Gets or sets the cases.
    public long Cases { get; set; }

    // Gets or sets the todayCases.
    public long TodayCases { get; set; }

    // Gets or sets the deaths.
    public long Deaths { get; set; }

    // Gets or sets the todayDeaths.
    public long DodayDeaths { get; set; }

    // Gets or sets the recovered.
    public long Recovered { get; set; }

    // Gets or sets the active.
    public long Active { get; set; }

    // Gets or sets the critical.
    public long Critical { get; set; }
       
    // Gets or Sets Population.
    public long Population { get; set; }

    // Gets or sets Tests.
    public long Tests { get; set; }
    
    // Gets or sets the continent.
    public string Continent { get; set; }
}
```

## Created by: Kodjo Laurent Egbakou

- LinkedIn: [Kodjo Laurent Egbakou](https://www.linkedin.com/in/laurentegbakou/)
- Twitter: [@lioncoding](https://twitter.com/lioncoding)

## License

The MIT License (MIT) see [License file](https://github.com/egbakou/Covid19Tracker.NET/blob/master/LICENSE)

## Contribution

Feel free to create issues and PRs 😃
## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://pufler.dev"><img src="https://avatars0.githubusercontent.com/u/17516174?v=4" width="100px;" alt=""/><br /><sub><b>puf17640</b></sub></a><br /><a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=puf17640" title="Code">💻</a> <a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=puf17640" title="Tests">⚠️</a> <a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=puf17640" title="Documentation">📖</a></td>
    <td align="center"><a href="https://lioncoding.com"><img src="https://avatars0.githubusercontent.com/u/26142591?v=4" width="100px;" alt=""/><br /><sub><b>Kodjo Laurent Egbakou</b></sub></a><br /><a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=egbakou" title="Code">💻</a> <a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=egbakou" title="Tests">⚠️</a> <a href="https://github.com/egbakou/Covid19Tracker.NET/commits?author=egbakou" title="Documentation">📖</a> <a href="#infra-egbakou" title="Infrastructure (Hosting, Build-Tools, etc)">🚇</a> <a href="#maintenance-egbakou" title="Maintenance">🚧</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!