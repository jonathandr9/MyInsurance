using System.ComponentModel.DataAnnotations;

namespace HinovaProvaAdapter
{
    public class HinovaAdapterConfiguration
    {
        [Required]
        public string ApiUrlBase { get; set; }
    }
}
