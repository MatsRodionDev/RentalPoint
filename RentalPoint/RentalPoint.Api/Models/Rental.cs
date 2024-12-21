using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Rental : BaseModel
    {
        public Guid ClientId { get; set; }
        public Guid ItemId { get; set; }
        public bool ItemIsBacked { get; set; } = false;
        public Client? Client { get; set; }
        public Item? Item { get; set; }
    }
}
