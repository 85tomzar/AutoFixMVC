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
    public DateTime Date { get; set; }
    [Display(Name = "Övriga önskemål")]
    public string OtherRequests { get; set; }
    [Display(Name = "Adress för upphämtning")]
    public string Address { get; set; }
}