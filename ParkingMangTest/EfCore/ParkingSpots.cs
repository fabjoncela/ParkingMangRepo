using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.EfCore
{
    [Table("parkingspots")]
    public class ParkingSpots
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public int? reservedSpots { get; set; }
        [Required]
        public int? freeSpots { get; set; }
        [Required]
        public int totalSpots { get; set; }
        public virtual ICollection<ParkingSpots> parkingSpots { get; set; }
        
    }
}
