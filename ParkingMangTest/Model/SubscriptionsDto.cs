﻿namespace ParkingMngV2.Model
{
    public class SubscriptionsDto
    {
        public int id { get; set; }
        public int code { get; set; }
        public int subscriberId { get; set; }
        public int price { get; set; }
        public DateOnly startDate { get; set; }
        public DateOnly endDate { get; set; }
    }
}
