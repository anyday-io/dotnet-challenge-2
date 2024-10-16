using System.ComponentModel.DataAnnotations;

namespace Anyday.IPExtractor.Models
{
    public class IpViewModel
    {
        [Display(Name = "Ip Address")]
        public string IpAddress { get; set; }
    }
}
