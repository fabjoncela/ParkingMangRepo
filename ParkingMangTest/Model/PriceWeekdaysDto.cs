namespace ParkingMngV2.Model
{
    public class PriceWeekdaysDto
    {
        public int Id { get; set; }
        public int hourlyPrice { get; set; }
        public int dailyPrice { get; set; }
        public int minimumHours { get; set; }
    }
}
