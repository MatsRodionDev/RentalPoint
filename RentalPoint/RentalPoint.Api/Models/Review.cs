using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Review : BaseModel
    {
        public Guid ItemId { get; set; }
        public Guid ClientId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime ReviewDate { get; set; }
        public Item? Item { get; set; }
        public Client? Client { get; set; }
    }
}
