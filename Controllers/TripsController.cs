using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using travel.Models;
using travel.Services;

namespace travel.Controllers
{
      [ApiController]
    [Route("api/[controller]")]
    public class TripsController: ControllerBase
    {
             private readonly TripService _service;
        public TripsController(TripService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Trip>> GetAll()
        {
            try
            {
                var data = _service.GetAll();
                return Ok(data);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Trip> GetOne( int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Trip> Create([FromBody] Trip newTrip)
        {
            try
            {
                return Ok(_service.Create(newTrip));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Trip> EditTrip([FromBody] Trip updatedTrip, int id)
        {
            try
            {
                updatedTrip.Id = id;
                return Ok(_service.EditTrip(updatedTrip));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteTrip(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok("Deleted");
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }







        
    }
}