using RentalPoint.Api.Interfaces.Entity;

namespace RentalPoint.Api.Abstracts
{
    public class BaseModel : IBaseModel
    {
        public Guid Id { get; set; }
    }
}
