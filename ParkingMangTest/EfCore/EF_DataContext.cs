using Microsoft.EntityFrameworkCore;

namespace ParkingMngV2.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext>
            options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }



        public DbSet<ParkingSpots> ParkingSpots { get; set; }
        public DbSet<Subscribers> Subscribers { get; set; }
        public DbSet<DailyLogs> DailyLogs { get; set; }
        public DbSet<PriceWeekdays> PriceWeekdays { get; set; }
        public DbSet<PriceWeekend> PriceWeekend { get; set;}
        public DbSet<Subscriptions> Subscriptions { get; set; }
        
        

    }
}
