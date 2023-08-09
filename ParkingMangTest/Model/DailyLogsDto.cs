namespace ParkingMngV2.Model
{
    public class DailyLogsDto
    {
        public int Id { get; set; }
        public int code { get; set; }
        public int subscriptionId { get; set; }
        public TimeOnly checkInt { get; set; }
        public TimeOnly checkOut {get; set; }
        public int price { get; set; }
    }
}
