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

    public async Task<int> Create(Domains.Domains.WeatherForecast weatherForecast)
    {
        if (weatherForecast == null)
            throw new ArgumentNullException("weatherForecast");

        await ENSPRONETContext.AddAsync(weatherForecast);

        return await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task<List<Domains.Domains.WeatherForecast>> List(int countryID)
    {
        if (countryID == default(int))
            throw new ArgumentNullException("countryID");

        return await ENSPRONETContext.WeatherForecast.Where(m => m.Country.Id == countryID).ToListAsync();
    }
}
