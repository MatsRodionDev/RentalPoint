namespace RentalPoint.Api.Dto
{
    public record PaymentRequest(
        Guid RentalId,
        decimal Amount,
        string PaymentMethod);
}
