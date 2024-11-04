using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class ItemCategory : BaseModel
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public Item? Item { get; set; }
        public Category? Category { get; set; }
    }
}
