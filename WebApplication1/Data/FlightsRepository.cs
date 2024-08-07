using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class FlightsRepository : IFlightsRepository
    {
        private List<Flight> _flights = new();

        public void Add(Flight flight)
        {
            flight.Id = _flights.Count + 1;
            _flights.Add(flight);
        }

        public List<Flight> GetAll()
        {
            return _flights;
        }

        public List<Flight> GetByLocation(string location)
        {
            return _flights.Where(x => x.DestinationLocation.ToLowerInvariant() == location.ToLowerInvariant()).ToList();
        }
    }
}
