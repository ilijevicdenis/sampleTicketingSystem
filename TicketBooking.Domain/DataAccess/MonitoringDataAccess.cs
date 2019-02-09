using System.Collections.Generic;
using TicketBooking.Domain.Models;

namespace TicketBooking.Domain.DataAccess
{
    public sealed class MonitoringDataAccess
    {

        public Monitoring GetMonitoringData()
        {
            return new Monitoring(MonitoringEntrances(), UserLogins(), PeopleCount(), AvaragesLengthOfStay, TotalIncome);
        }

        private IEnumerable<MonitoringEntrance> MonitoringEntrances()
        {
            return new List<MonitoringEntrance>
                {
                    new MonitoringEntrance("123456789", "9:00", "01:00:00", default(decimal)),
                    new MonitoringEntrance("123456789", "9:00", "01:00:00", default(decimal)),
                    new MonitoringEntrance("123456789", "9:00", "01:00:00", default(decimal))
                };
        }

        private IEnumerable<UserLogin> UserLogins()
        {
            return new List<UserLogin>()
                {
                    new UserLogin("Kowalski", "Roman", "8:00", "02:00:34")
                };
        }

        private int PeopleCount() => 100;
        private string AvaragesLengthOfStay => "2:00:40";
        private decimal TotalIncome => 100.00M; 

    }
}
