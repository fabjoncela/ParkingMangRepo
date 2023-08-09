using System.ComponentModel.DataAnnotations;

namespace ParkingMngV2.Model
{
    public class SubscribersDto
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int cardNumberId { get; set; }
        public string email { get; set; }   
        public string phoneNumber { get; set; }   
        public DateOnly birthday { get; set; }
        public string plateNumber { get; set; }
    }
}
