namespace RentalPoint.Api.Dto
{
    public record EventResponse(
        Guid Id,
        string Description,
        DateTime StartDate,
        DateTime EndDate);
}
