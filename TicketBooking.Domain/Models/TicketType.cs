namespace TicketBooking.Domain.Models
{
    public sealed class TicketType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public decimal Deposit { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int NumberOfTickets { get; set; }
        public bool IsChildAllowedToTakeDrinksIndependently { get; set; }
        public bool IsChiledAllowedToTakeFoodForHimself { get; set; }

    }
}
