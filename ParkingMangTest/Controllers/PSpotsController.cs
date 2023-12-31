﻿using Microsoft.AspNetCore.Mvc;
using ParkingMangTest.Model;
using ParkingMngV2.EfCore;
using ParkingMngV2.Model;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Kiota.Abstractions;

namespace ParkingMngV2.Controllers
{
    [ApiController]
    
    public class PSpotsController : ControllerBase
    {
        private readonly DbHelper _db;
        public PSpotsController(EF_DataContext eF_DataContext, DbHelper db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("api/[controller]/GetParkingSpots")]

        public IActionResult Get()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<ParkingSpots> data = _db.GetParkingSpots();
                
                if(!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                //type = ResponseType.Failure;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }
        [HttpPut]
        [Route("api/[controller]/UpdateParkingSpots")]
        public IActionResult Put([FromBody] ParkingSpotsDto parkingSpots)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.UpdateParkingSpots(parkingSpots);
                return Ok(ResponseHandler.GetAppResponse(type, parkingSpots));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }








    }
}
