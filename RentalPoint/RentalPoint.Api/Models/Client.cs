namespace RentalPoint.Api.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public ICollection<Rental>? Rentals { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
