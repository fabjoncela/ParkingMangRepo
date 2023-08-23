using Microsoft.AspNetCore.Mvc;
using ParkingMangTest.Model;
using ParkingMngV2.EfCore;
using ParkingMngV2.Model;

namespace ParkingMangTest.Controllers
{
    [ApiController]
    public class WeekPricesController : ControllerBase
    {
        private readonly DbHelper _db;
        public WeekPricesController(EF_DataContext eF_DataContext, DbHelper db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("api/[controller]/GetPriceWeekdays")]
        public IActionResult GetPriceWeekdays()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<PriceWeekdays> data = _db.GetPriceWeekdays();
                if(!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }
        [HttpPut]
        [Route("api/[controller]/UpdatePriceWeekdays")]
        public IActionResult SavePriceWeekdays([FromBody] PriceWeekdaysDto priceWeekdays)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.PutPriceWeekdays(priceWeekdays);
                return Ok(ResponseHandler.GetAppResponse(type, priceWeekdays));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        [HttpGet]
        [Route("api/[controller]/GetPriceWeekend")]
        public IActionResult GetPriceWeekend()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<PriceWeekend> data = _db.GetPriceWeekend();
                if(!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        [HttpPut]
        [Route("api/[controller]/UpdatePriceWeekend")]
        public IActionResult PutPriceWeekend([FromBody] PriceWeekendDto priceWeekend)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.PutPriceWeekend(priceWeekend);
                return Ok(ResponseHandler.GetAppResponse(type, priceWeekend));
            }
            catch(Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }


















    }
}
