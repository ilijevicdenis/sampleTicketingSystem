using TicketBooking.Domain.DataAccess;
using TicketBooking.Domain.Models;

namespace TicketBooking.ViewModels
{
    sealed public class MainViewViewModel 
    {
        public Monitoring MonitoringData { get; private set; }

        public MainViewViewModel(MonitoringDataAccess monitoringDataProvider)
        {
            MonitoringData = monitoringDataProvider.GetMonitoringData();
        }
    }
}
