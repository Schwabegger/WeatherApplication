using Microsoft.Extensions.Options;
using OpenWeatherMap;
using WeatherApi.Interfaces;
using WeatherApi.Options;

namespace WeatherApi.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly OpenWeatherMapClient _openWeatherMapClient;
        private readonly IOptions<OpenWeatherMapApiOptions> _options;

        public WeatherService(IOptions<OpenWeatherMapApiOptions> options)
        {
            _openWeatherMapClient = new OpenWeatherMapClient();
            _openWeatherMapClient.AppId = options.Value.ApiKey;
            _options = options;
        }

        public async Task<CurrentWeatherResponse> GetWeatherData(string city)
        {
            return await _openWeatherMapClient.CurrentWeather.GetByName(city);
        }
    }
}