﻿namespace RentalPoint.Api.Dto
{
    public record ClientRequest(
         string FirstName,
         string LastName,
         string Email,
         string PhoneNumber);
}
