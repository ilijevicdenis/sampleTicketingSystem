using System.Collections.Generic;

namespace TicketBooking.Domain.Models
{
    public class Monitoring
    {
        public IReadOnlyCollection<MonitoringEntrance> MonitoringEntrances { get; private set; }
        public IReadOnlyCollection<UserLogin> UserLogins { get; private set; }
        public int PeopleCount { get; private set; }
        public string AvaragesLengthOfStay {get; private set; }
        public decimal TotalIncome { get; private set; }

        internal Monitoring(IEnumerable<MonitoringEntrance> monitoringEntrances, IEnumerable<UserLogin> userLogins,
                            int peopleCount, string avaragesLengthOfStay, decimal totalIncome)
        {
            MonitoringEntrances = new List<MonitoringEntrance>(monitoringEntrances);
            UserLogins = new List<UserLogin>(userLogins);
            PeopleCount = peopleCount;
            AvaragesLengthOfStay = avaragesLengthOfStay;
            TotalIncome = totalIncome;
        }
    }
}
