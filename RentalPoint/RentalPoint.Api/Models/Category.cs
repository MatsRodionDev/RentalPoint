using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<ItemCategory>? ItemCategories { get; set; }
    }
}
