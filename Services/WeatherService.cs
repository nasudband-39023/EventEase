using System.Net.Http.Json;
using EventEaseProject.Models;


namespace EventEaseProject.Services
{
    public class WeatherService
    {
        public async Task<WeatherModel?> GetWeatherAsync(string city)
        {
            // Delay simulation to mimic an API call
            await Task.Delay(300);

            return city.ToLower() switch
            {
                "seattle" => new WeatherModel
                {
                    name = "Seattle",
                    main = new Main { temp = 16.3, humidity = 78 },
                    weather = new List<Weather>
                    {
                        new Weather { description = "Cloudy", icon = "03d" }
                    }
                },
                "new york" => new WeatherModel
                {
                    name = "New York",
                    main = new Main { temp = 23.1, humidity = 60 },
                    weather = new List<Weather>
                    {
                        new Weather { description = "Sunny", icon = "01d" }
                    }
                },
                "san francisco" => new WeatherModel
                {
                    name = "San Francisco",
                    main = new Main { temp = 18.5, humidity = 70 },
                    weather = new List<Weather>
                    {
                        new Weather { description = "Foggy", icon = "50d" }
                    }
                },
                _ => null
            };
        }

        public async Task<List<WeatherModel>> GetWeatherForCitiesAsync(List<string> cities)
        {
            var list = new List<WeatherModel>();

            foreach (var city in cities)
            {
                var weather = await GetWeatherAsync(city);
                if (weather != null)
                    list.Add(weather);
            }

            return list;
        }
    }
}