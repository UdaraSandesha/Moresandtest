using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class FlightsService : IFlightsService
    {
        private readonly IFlightsRepository _flightsRepository;

        public FlightsService(IFlightsRepository flightsRepository)
        {
            _flightsRepository = flightsRepository;
        }

        public void AddFlight(FlightModel flight)
        {
            var flightEntity = new Flight(flight.DepartureLocation, flight.DestinationLocation, flight.DepartureTime, flight.ArrivalTime, flight.NoOfAvailableSeats);
            _flightsRepository.Add(flightEntity);
        }

        public List<FlightModel> GetAllFlights()
        {
            var flights = _flightsRepository.GetAll();

            return flights.Select(x => new FlightModel
            {
                ArrivalTime = x.ArrivalTime,
                DepartureTime= x.DepartureTime,
                DestinationLocation = x.DestinationLocation,
                NoOfAvailableSeats = x.NoOfAvailableSeats
            }).ToList();
        }

        public List<FlightModel> GetAllFlightsByLocation(string location)
        {
            var flights = _flightsRepository.GetByLocation(location);

            return flights.Select(x => new FlightModel
            {
                ArrivalTime = x.ArrivalTime,
                DepartureTime= x.DepartureTime,
                DestinationLocation = x.DestinationLocation,
                NoOfAvailableSeats = x.NoOfAvailableSeats
            }).ToList();
        }
    }
}
