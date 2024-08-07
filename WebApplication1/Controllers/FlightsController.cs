using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightsService _flightService;
        public FlightsController(IFlightsService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("{location}")]
        public ActionResult<List<FlightModel>> GetFlightsByLocation([FromRoute] string location)
        {
            var flights = _flightService.GetAllFlightsByLocation(location);
            return Ok(flights);
        }

        [HttpPost]
        public IActionResult CreateFlight([FromBody] FlightModel model)
        {
            _flightService.AddFlight(model);
            return Ok();
        }
    }
}
