using Microsoft.AspNetCore.Mvc;
using ParkingMangTest.Model;
using ParkingMngV2.EfCore;
using ParkingMngV2.Model;
using Microsoft.EntityFrameworkCore;

namespace ParkingMangTest.Controllers
{
    [ApiController]
    public class SubscribersController : ControllerBase
    {
        private readonly DbHelper _db;
        public SubscribersController(EF_DataContext eF_DataContext, DbHelper db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("api/[controller]/GetSubscribers")]
        public IActionResult GetSubscribers() 
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<Subscribers> data = _db.GetSubscriber();
                if (!data.Any())
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

        [HttpGet]
        [Route("api/[controller]/GetSubscriber")]
        public IActionResult GetSubscribers(string? firstName, string? lastName, int? cardNrId, string? email) 
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<Subscribers> data = _db.GetSubscriber();

                if (!string.IsNullOrEmpty(firstName))
                {
                    data = data.Where(subscriber => subscriber.firstName == firstName);
                }

                if (!string.IsNullOrEmpty(lastName))
                {
                    data = data.Where(subscriber => subscriber.lastName == lastName);
                }

                if (cardNrId.HasValue)
                {
                    data = data.Where(subscriber => subscriber.cardNumberId == cardNrId);
                }

                if (!string.IsNullOrEmpty(email))
                {
                    data = data.Where(subscriber => subscriber.email == email);
                }

                if (!data.Any())
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






    }
}
