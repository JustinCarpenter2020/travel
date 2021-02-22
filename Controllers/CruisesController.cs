using Microsoft.AspNetCore.Mvc;
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


        
        
    }
}