namespace RentalPoint.Api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        public ICollection<Rental>? Rentals { get; set; }
        public ICollection<ItemCategory>? ItemCategories { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
