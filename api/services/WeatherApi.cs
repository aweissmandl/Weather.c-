namespace Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json",optional: false);
{
    return new WeatherApi(
        ConfigurationBinder.GetRequierService<IConfiguration>()["Weather:ApiKey"]!
    )
}
public class WeatherApi
{
    private const String ApiKey = 
    public WeatherApi(string apikey)
    {
        this.apiKey= ApiKey;
    }

    public string GetWeather(string zipcode)
    {
        var httpClient = new HttpClient();


        var url = $"https://api.weatherapi.com/v1/current.json?key={ApiKey}&q={zipcode}&aqi=no";

        var response = httpClient.GetAsync(url).Result;

        return response.Content.ReadAsStringAsync().Result;
    }
}



