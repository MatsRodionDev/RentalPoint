using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Discount : BaseModel
    {
        public string Description { get; set; } = string.Empty;
        public decimal Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
