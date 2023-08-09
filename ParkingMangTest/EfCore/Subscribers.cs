using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.EfCore
{
    [Table("subscribers")]
    public class Subscribers
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public int cardNumberId { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public DateOnly birthday { get; set; }
        [Required]
        public string plateNumber { get; set; }

        public virtual ICollection<Subscribers> subscribers
        { get; set; }
    }
}
