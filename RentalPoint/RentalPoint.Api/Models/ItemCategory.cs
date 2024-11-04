namespace RentalPoint.Api.Models
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public Item? Item { get; set; }
        public Category? Category { get; set; }
    }
}
