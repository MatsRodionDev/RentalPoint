using RentalPoint.Api.Abstracts;

namespace RentalPoint.Api.Models
{
    public class Event : BaseModel
    {
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
