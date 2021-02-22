using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using travel.Models;
using travel.Services;

namespace travel.Controllers
{
      [ApiController]
    [Route("api/[controller]")]
    public class CruisesController: ControllerBase
    {
        private readonly CruiseService _service;
        public CruisesController(CruiseService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Cruise>> GetAll()
        {
            try
            {
                 var data = _service.GetAll();
                 return Ok(data);
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Cruise> GetOne(int id)
        {
            try
            {
                return Ok(_service.GetOne(id));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Cruise> Create([FromBody] Cruise newCruise)
        {
            try
            {
                return Ok(_service.Create(newCruise));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Cruise> EditCruise([FromBody] Cruise updatedCruise, int id)
        {
            try
            {
                updatedCruise.Id = id;
                return Ok(_service.Edit(updatedCruise));
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
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