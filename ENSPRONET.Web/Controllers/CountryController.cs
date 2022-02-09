using ENSPRONET.Services.Services.Country;
using Microsoft.AspNetCore.Mvc;
using ENSPRONET.Domains.Domains;
using ENSPRONET.Web.Models.Country;

namespace ENSPRONET.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> logger;
    private readonly ICountryReadService countryReadService;
    private readonly ICountryCreateService countryCreateService;

    public CountryController(ILogger<CountryController> logger, ICountryReadService countryReadService, ICountryCreateService countryCreateService)
    {
        this.logger = logger;
        this.countryReadService = countryReadService;
        this.countryCreateService = countryCreateService;
    }

    [HttpGet]
    public async Task<ActionResult<string>> Get(string alpha2Code)
    {
        if (string.IsNullOrEmpty(alpha2Code))
            return BadRequest();

        Country selectedObject = await countryReadService.ReadByAlpha2Code(alpha2Code);

        CountryReadMode countryReadModel = new CountryReadMode();
        countryReadModel.Map(selectedObject);

        return Ok(countryReadModel);
    }


    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CountryCreateModel countryCreateModel)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        Country countryDomain = countryCreateModel.Map();

        return await countryCreateService.Create(countryDomain);
    }
}
