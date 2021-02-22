using Microsoft.AspNetCore.Mvc;
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







        
    }
}