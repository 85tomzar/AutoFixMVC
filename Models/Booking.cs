using System.ComponentModel.DataAnnotations;

namespace AutoFix.Models;

public class Booking
{
    public int Id { get; set; } 
    [Display(Name = "Bil")]
    public string Car { get; set; }
    [Display(Name = "Tjänst")]
    public string Service { get; set; }
    [Display(Name = "Datum och tid för upphämtning")]
    [DisplayFormat(DataFormatString = "{0:dd MMM yyyy} {0:HH:mm}")]
    public DateTime Date { get; set; }
    [Display(Name = "Tillval")]
    public string OtherRequests { get; set; }
    [Display(Name = "Adress för upphämtning")]
    public string Address { get; set; }
    [Display(Name = "Tvättning")]
    public bool ExtraWashing { get; set; }
    [Display(Name = "Däckkontroll")]
    public bool ExtraCheckTires { get; set; }
    [Display(Name = "Tankning")]
    public bool ExtraFillGas { get; set; }

}