namespace ENSPRONET.Services.Services.Country;

public class CountryService : ICountryReadService
{
    public Task<List<Domains.Domains.Country>> List()
    {
        throw new NotImplementedException();
    }

    public Task<Domains.Domains.Country> ReadByAlpha2Code(string code)
    {
        throw new NotImplementedException();
    }
}
