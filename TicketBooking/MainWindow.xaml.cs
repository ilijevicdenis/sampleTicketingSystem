using System.Windows;
using TicketBooking.ViewModels;

namespace TicketBooking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewViewModel(new Domain.DataAccess.MonitoringDataAccess());
            InitializeComponent();
        }
    }
}
