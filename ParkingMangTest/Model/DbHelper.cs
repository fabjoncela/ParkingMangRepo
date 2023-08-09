using ParkingMngV2.EfCore;

namespace ParkingMngV2.Model
{
    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)//constructor
        {
            _context = context;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public List<ParkingSpots> GetParkingSpots()
        {
            List<ParkingSpots> response = new List<ParkingSpots>();
            var dataList = _context.ParkingSpots.ToList();
            dataList.ForEach(row => response.Add(new ParkingSpots(){
                Id = row.Id,
                reservedSpots = row.reservedSpots,
                freeSpots = row.freeSpots,
                totalSpots = row.totalSpots,
            }
            ));
            return response;
        }

    }
}
