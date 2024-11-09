using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Rental : BaseModel
    {
        public Guid ClientId { get; set; }
        public Guid ItemId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Client? Client { get; set; }
        public Item? Item { get; set; }
        public Payment? Payment { get; set; }
    }
}
