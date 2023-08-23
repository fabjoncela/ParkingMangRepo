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
        /// it doest the Put/Patch/Post
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
                }
                //else
                //{
                    
                //}
                _context.SaveChanges();
            }
        }

        public List<PriceWeekdays> GetPriceWeekdays()
        {
            List<PriceWeekdays> response = new List<PriceWeekdays>();
            var dataList = _context.priceWeekdays.ToList();
            dataList.ForEach(row => response.Add(new PriceWeekdays()
            {
                Id = row.Id,
                dailyRate = row.dailyRate,
                hourlyRate = row.hourlyRate, 
                minimumHours = row.minimumHours,
            }));
            return response;
        }

        public void PutPriceWeekdays(PriceWeekdaysDto priceWeekdays)
        {
            PriceWeekdays dbTable = new PriceWeekdays();
            if (priceWeekdays.Id > 0)
            {
                //this is the put method for the Weekdays Price
                dbTable = _context.priceWeekdays.Where(d => d.Id.Equals(priceWeekdays.Id)).FirstOrDefault();
                if (dbTable != null)
                {
                    dbTable.hourlyRate = priceWeekdays.hourlyPrice;
                    dbTable.dailyRate = priceWeekdays.dailyPrice;
                    dbTable.minimumHours = priceWeekdays.minimumHours;
                }
                _context.SaveChanges();
            }
        }

        public List<PriceWeekend> GetPriceWeekend()
        {
            List<PriceWeekend> response = new List<PriceWeekend>();
            var dataList = _context.priceWeekend.ToList();
            dataList.ForEach(row => response.Add(new PriceWeekend()
            {
                Id = row.Id,
                hourlyRate = row.hourlyRate,
                minimumHours = row.minimumHours,
                dailyRate = row.dailyRate

            }));
            return response;
        }
        public void PutPriceWeekend(PriceWeekendDto priceWeekend)
        {
            PriceWeekend dbTable = new PriceWeekend();
            if(priceWeekend.Id > 0)
            {
                //the code for PUT
                dbTable = _context.priceWeekend.Where(d => d.Id.Equals(priceWeekend.Id)).FirstOrDefault();
                if (dbTable != null)
                {
                    dbTable.hourlyRate = priceWeekend.hourlyPrice;
                    dbTable.dailyRate = priceWeekend.dailyPrice;
                    dbTable.minimumHours = priceWeekend.minimumHours;
                }
                _context.SaveChanges();
            }
        }
        public List<Subscribers> GetSubscriber()
        {
            List<Subscribers> response = new List<Subscribers>();
            var dataList = _context.subscribers.ToList();
            dataList.ForEach(row => response.Add(new Subscribers()
            {
                Id = row.Id,
                firstName = row.firstName,
                lastName = row.lastName,
                phoneNumber = row.phoneNumber,
                cardNumberId = row.cardNumberId,
                plateNumber = row.plateNumber,
                email = row.email,
                birthday = row.birthday,
                isDeleted = row.isDeleted
            }));
            return response;
        }















    }
}
