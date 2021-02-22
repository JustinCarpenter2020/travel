namespace travel.Models
{
    public class Trip: Vacation
    {
        public bool CarRental { get; set; }
        public int Hotels { get; set; }
    }
}