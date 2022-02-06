using ENSPRONET.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace ENSPRONET.Services.Services.Country;

public class CountryService : ICountryReadService, ICountryCreateService
{
    private readonly ENSPRONETContext ENSPRONETContext;
    public CountryService(ENSPRONETContext ensproNetContext)
    {
        ENSPRONETContext = ensproNetContext;
    }

    public async Task<int> Create(Domains.Domains.Country country)
    {
        if (country == null)
            throw new ArgumentNullException("country");

        ENSPRONETContext.Add(country);

        await ENSPRONETContext.SaveChangesAsync();

        return country.Id;
    }

    public async Task CreateBulk(List<Domains.Domains.Country> countries)
    {
        if (countries == null || countries?.Count == 0)
            throw new ArgumentNullException("countries");

        ENSPRONETContext.AddRange(countries);

        await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task<List<Domains.Domains.Country>> List()
    {
        return ENSPRONETContext.Countries.ToList();
    }

    public async Task<Domains.Domains.Country> ReadByAlpha2Code(string code)
    {
        if (String.IsNullOrEmpty(code))
            throw new ArgumentNullException(code);

        return await ENSPRONETContext.Countries.FirstAsync(m => m.Alpha2Code == code);
    }
}
