namespace HW_09.Booking.com.Models
{
    public class User
    {
        public bool IsRegisteredOnBookingDotCom;

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public Apartment SelectApartment(Apartment[] aparments)
        {
            return aparments[0];
        }
    }
}
