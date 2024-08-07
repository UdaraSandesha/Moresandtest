namespace WebApplication1.Models
{
    public class FlightModel
    {
        public string DepartureLocation { get; set; } = string.Empty;
        public string DestinationLocation { get; set; } = string.Empty;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int NoOfAvailableSeats { get; set; }
    }
}
