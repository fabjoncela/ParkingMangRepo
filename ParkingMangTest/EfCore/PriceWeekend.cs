using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.EfCore
{
    [Table("priceweekend")]
    public class PriceWeekend
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        public int hourlyRate { get; set; }
        [Required]
        public int dailyRate { get; set; }
        [Required]
        public int minimumHours { get; set; }
       // public virtual ICollection<PriceWeekend> priceweekend { get; set; }
    }
}
