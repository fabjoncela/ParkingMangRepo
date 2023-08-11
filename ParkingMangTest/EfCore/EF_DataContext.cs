using Microsoft.EntityFrameworkCore;

namespace ParkingMngV2.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }



        public DbSet<ParkingSpots> parkingSpots { get; set; }
        public DbSet<Subscribers> subscribers { get; set; }
        public DbSet<DailyLogs> dailyLogs { get; set; }
        public DbSet<PriceWeekdays> priceWeekdays { get; set; }
        public DbSet<PriceWeekend> priceWeekend { get; set;}
        public DbSet<Subscriptions> subscriptions { get; set; }
        
        

    }
}
