using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IFlightsService
    {
        List<FlightModel> GetAllFlights();
        List<FlightModel> GetAllFlightsByLocation(string location);
        void AddFlight(FlightModel flight);
    }
}
