namespace WebApplication1.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetAllForecasts();
    }
}
