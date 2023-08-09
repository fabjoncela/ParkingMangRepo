//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMngV2.Model
{
    
    public class ParkingSpotsDto
    {
        
        public int Id { get; set; }
        public int reservedSpots { get; set; }
        public int freeSpots { get; set; }
        public int totalSpots { get; set; }
        public ParkingSpotsDto() 
        {
            totalSpots = reservedSpots + freeSpots;
        }
    }
}
