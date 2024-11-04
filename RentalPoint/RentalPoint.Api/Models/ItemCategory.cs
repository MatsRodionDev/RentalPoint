using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class ItemCategory : BaseModel
    {
        public Guid ItemId { get; set; }
        public Guid CategoryId { get; set; }
        public Item? Item { get; set; }
        public Category? Category { get; set; }
    }
}
