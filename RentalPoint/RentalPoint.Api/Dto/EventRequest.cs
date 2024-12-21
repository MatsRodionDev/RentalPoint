namespace RentalPoint.Api.Dto
{
    public record EventRequest(
        string Description,
        DateTime StartDate,
        DateTime EndDate);
}
