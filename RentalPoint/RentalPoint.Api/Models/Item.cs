using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Item : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsRented { get; set; } = false;
        public Guid CategoryId { get; set; }
        public ICollection<Rental>? Rentals { get; set; }
        public Category? Category { get; set; }
    }
}
