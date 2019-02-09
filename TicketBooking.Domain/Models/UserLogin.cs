namespace TicketBooking.Domain.Models
{
    public sealed class UserLogin
    {
        public string Surname { get; private set; }
        public string Firstname { get; private set; }
        public string LoginTime { get; private set; }
        public string WorkTime { get; private set; }

        public UserLogin(string surname, string firstName, string loginTime, string workTime)
        {
            Surname = surname;
            Firstname = firstName;
            LoginTime = loginTime;
            WorkTime = workTime;
        }
    }
}
