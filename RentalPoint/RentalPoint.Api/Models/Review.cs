namespace RentalPoint.Api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ClientId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime ReviewDate { get; set; }
        public Item? Item { get; set; }
        public Client? Client { get; set; }
    }
}
