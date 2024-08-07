namespace WebApplication1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public List<Flight> Flights { get; set; } = new();
    }
}
