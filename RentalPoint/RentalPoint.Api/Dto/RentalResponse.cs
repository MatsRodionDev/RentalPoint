namespace RentalPoint.Api.Dto
{
    public record RentalResponse(
        ItemRequest Item,
        DateTime RentalDate,
        DateTime ReturnDate);
}
