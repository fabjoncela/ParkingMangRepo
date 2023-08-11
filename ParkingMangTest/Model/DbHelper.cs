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
            var dataList = _context.parkingSpots.ToList();
            dataList.ForEach(row => response.Add(new ParkingSpots(){
                ParkingSpotsId = row.ParkingSpotsId,
                reservedSpots = row.reservedSpots,
                freeSpots = row.freeSpots,
                totalSpots = row.totalSpots
            }
            ));
            return response;
        }
        /*
        public ParkingSpots GetParkingSpotsById(int ParkingSpotsId)
        {
            ParkingSpots response = new ParkingSpots();
            var row = _context.ParkingSpots.Where(d=>d.ParkingSpotsId.Equals(ParkingSpotsId)).FirstOrDefault();
            return new ParkingSpots()
            {
                ParkingSpotsId = row.ParkingSpotsId,
                reservedSpots = row.reservedSpots,
                freeSpots = row.freeSpots,
                totalSpots = row.totalSpots
            };            
        }
        */



        /// <summary>
        /// Put/Patch
        /// </summary>
        /// <param name="parkingSpotsDto"></param>
        public void UpdateParkingSpots(ParkingSpotsDto parkingSpotsDto)
        {
            ParkingSpots dbTable = new ParkingSpots();
            if(parkingSpotsDto.Id > 0)
            {
                //put
                dbTable = _context.parkingSpots.Where(d => d.ParkingSpotsId.Equals(parkingSpotsDto.Id)).FirstOrDefault();
                if (dbTable != null)//nqs ka tablea t dhena
                {    

                    dbTable.reservedSpots = parkingSpotsDto.reservedSpots;
                    dbTable.freeSpots = parkingSpotsDto.freeSpots;
                    dbTable.totalSpots = parkingSpotsDto.totalSpots;
                }
                //else
                //{
                    
                //}
                _context.SaveChanges();
            }
        }

        



    }
}
