using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using travel.Models;
using travel.Services;

namespace travel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacationsController : ControllerBase
    {
             private readonly VacationService _service;
        public VacationsController(VacationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vacation>> Get()
        {
            try
            {
                return Ok(_service.getAll());
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }





        
    }
}