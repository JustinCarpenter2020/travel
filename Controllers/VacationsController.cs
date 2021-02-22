using Microsoft.AspNetCore.Mvc;
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





        
    }
}