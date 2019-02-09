namespace TicketBooking.Domain.Models
{
    public sealed class MonitoringEntrance
    {
        public string EntryId { get; private set; }
        public string EntryTime { get; private set; }
        public string Time { get; private set; }
        public decimal TotalPrice { get; private set; }

        public MonitoringEntrance(string entryId, string entryTime, string time, decimal totalPrice)
        {
            EntryId = entryId;
            EntryTime = entryTime;
            Time = time;
            TotalPrice = totalPrice;
        }
    }
}
