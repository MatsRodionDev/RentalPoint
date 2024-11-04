namespace RentalPoint.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ItemCategory>? ItemCategories { get; set; }
    }
}
