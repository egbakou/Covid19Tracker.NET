using System;
using Xunit;
using static Covid19Tracker.Services.Covid19TrackerAPI;

namespace Covid19Tracker.UnitTest
{
    public class Covid19TrackerTest
    {
        [Fact]
        public async void TestGetGlobalDataAsync()
        {
            var data = await GetGlobalDataAsync();
            Assert.NotNull(data);
        }

        [Fact]
        public async void TestGetContinentsDataAsync()
        {
            var data = await GetContinentsDataAsync();
            Assert.True(data.Count > 0);
            Assert.False(data.Count > 6);
        }

        [Fact]
        public async void TestGetDataByContinentAsync()
        {
            var correct_continent = "africa";
            var wrong_continent = "afri";
            var data = await GetDataByContinentAsync(correct_continent);
            Assert.NotNull(data);
            await Assert.ThrowsAsync<Exception>(async()=> await GetDataByContinentAsync(wrong_continent));
        }

        [Fact]
        public async void TestGetCountriesDataAsync()
        {
            var data = await GetCountriesDataAsync();
            Assert.True(data.Count > 0);
            Assert.False(data.Count < 100);
        }


        [Fact]
        public async void TestGetDataByCountryAsync()
        {
            var correct_country = "togo";
            var wrong_country = "tog";
            var data = await GetDataByCountryAsync(correct_country);
            Assert.NotNull(data);
            await Assert.ThrowsAsync<Exception>(async () => await GetDataByCountryAsync(wrong_country));
        }
    }
}
