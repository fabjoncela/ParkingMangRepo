﻿namespace ParkingMngV2.Model
{
    public class PriceWeekendDto
    {
        public int Id { get; set; }
        public int hourlyPrice { get; set; }
        public int dailyPrice { get; set; }
        public int minimumHours { get; set; }
    }
}
