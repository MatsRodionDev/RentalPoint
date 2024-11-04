using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Client : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public ICollection<Rental>? Rentals { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
