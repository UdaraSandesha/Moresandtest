namespace WebApplication1.Entities
{
    public class Flight
    {
        public Flight(string departureLocation, string destinationLocation, DateTime departureTime, DateTime arrivalTime, int noOfAvailableSeats)
        {
            DepartureLocation = departureLocation;
            DestinationLocation = destinationLocation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            NoOfAvailableSeats = noOfAvailableSeats;
        }

        public int Id { get; set; }
        public string DepartureLocation { get; set; } = string.Empty;
        public string DestinationLocation { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int NoOfAvailableSeats { get; set; }
    }
}
