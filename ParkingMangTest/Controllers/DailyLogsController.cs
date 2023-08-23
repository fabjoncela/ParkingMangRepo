using Microsoft.AspNetCore.Mvc;
using ParkingMngV2.EfCore;
using ParkingMngV2.Model;
using Microsoft.EntityFrameworkCore;

namespace ParkingMangTest.Controllers
{
    [ApiController]
    public class DailyLogsController : ControllerBase
    {
        private readonly DbHelper _db;
        public DailyLogsController(EF_DataContext eF_DataContext, DbHelper db)
        {
            _db = db;
        }
        //[HttpGet]
        //[Route("api/[controller]/GetDailyLogs")]
        /*public IActionResult GetDailyLogs()
        {
            try
            {
               
            }
        }*/







    }
}
