namespace RentalPoint.Api.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ItemId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Client? Client { get; set; }
        public Item? Item { get; set; }
    }
}
