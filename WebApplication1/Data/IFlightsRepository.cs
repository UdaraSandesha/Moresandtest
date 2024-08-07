using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public interface IFlightsRepository
    {
        List<Flight> GetAll();
        List<Flight> GetByLocation(string location);
        void Add(Flight flight);
    }
}
