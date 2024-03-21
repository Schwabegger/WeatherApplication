using OpenWeatherMap;

namespace WeatherApi.Interfaces
{
    public interface IWeatherService
    {
        Task<CurrentWeatherResponse> GetWeatherData(string city);
    }
}