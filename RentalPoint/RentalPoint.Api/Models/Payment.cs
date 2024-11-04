using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Payment : BaseModel
    {
        public Guid RentalId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public Rental? Rental { get; set; }
    }
}
