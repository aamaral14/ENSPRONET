using System.ComponentModel.DataAnnotations;

namespace ENSPRONET.Web.Models.Country;

public class CountryCreateModel
{
    [Required]
    public string CountryName { get; set; }
    [Required]
    [StringLength(2)]
    public string Alpha2Code { get; set; }
    [Required]
    [StringLength(3)]
    public string Alpha3Code { get; set; }
    [Required]
    public int NumericCode { get; set; }
    public string SubDivisionCode { get; set; }
    public string InternetDomain { get; set; }
}
