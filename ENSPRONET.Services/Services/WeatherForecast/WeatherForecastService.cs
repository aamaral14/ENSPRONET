using ENSPRONET.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace ENSPRONET.Services.Services.WeatherForecast;

public class WeatherForecastService : IWeatherForecastReadService, IWeatherForecastCreateService
{
    private readonly ENSPRONETContext ENSPRONETContext;
    public WeatherForecastService(ENSPRONETContext ensproNetContext)
    {
        ENSPRONETContext = ensproNetContext;
    }

    public async Task<int> Create(Domains.Domains.WeatherForecast weatherForecast, int countryID)
    {
        if (weatherForecast == null || countryID == default(int))
            throw new ArgumentNullException("weatherForecast or contryID");

        var country = await ENSPRONETContext.Countries.Include(m => m.WeatherForecasts).FirstAsync(m => m.Id == countryID);

        country.WeatherForecasts.Add(weatherForecast);

        return await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task<List<Domains.Domains.WeatherForecast>> List(int countryID)
    {
        if (countryID == default(int))
            throw new ArgumentNullException("countryID");

        return await ENSPRONETContext.WeatherForecast.Where(m => m.Country.Id == countryID).ToListAsync();
    }
}
