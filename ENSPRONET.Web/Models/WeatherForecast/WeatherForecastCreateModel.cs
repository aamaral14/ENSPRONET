namespace ENSPRONET.Web.Models.WeatherForecast;

using Domains.Domains;

public class WeatherForecastCreateModel
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    public string? Summary { get; set; }

    public int CountryID { get; set; }


    public WeatherForecast Map()
    {
        return new WeatherForecast()
        {
            Id = this.Id,
            Date = this.Date,
            TemperatureC = this.TemperatureC,
            TemperatureF = this.TemperatureF,
            Summary = this.Summary,
            Country = new Country() { Id = this.CountryID }
        };
    }
}