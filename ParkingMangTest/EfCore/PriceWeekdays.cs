using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.EfCore
{
    [Table("priceweekdays")]
    public class PriceWeekdays
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public int hourlyRate { get; set; }
        [Required]
        public int dailyRate { get; set; }
        [Required]
        public int minimumHours { get; set; }
       // public virtual ICollection<PriceWeekdays> priceweekdays { get; set; }
    }
}
