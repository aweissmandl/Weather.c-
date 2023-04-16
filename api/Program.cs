using Api.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Earth!");

app.MapGet("/{zipcode}",(string zipcode)=>
{
    var weatherApi = new WeatherApi();

    return weatherApi.GetWeather(zipcode);

});


app.Run();
