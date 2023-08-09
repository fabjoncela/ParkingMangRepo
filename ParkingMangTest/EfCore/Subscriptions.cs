using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.EfCore
{
    [Table("subscriptions")]
    public class Subscriptions
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        public int code { get; set; }
        [Required]
        public virtual Subscribers Subscribers { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public DateOnly startDate { get; set; }
        [Required]
        public DateOnly endDate { get; set; }


        public virtual ICollection<Subscriptions> subscriptions { get; set; }
    }
}
