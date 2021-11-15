using HW_09.Booking.com.Models;

namespace HW_09.Booking.com
{
    public class BookingSite
    {
        public bool IsUserSignedIn { get; internal set; }

        public ApartmentPage OpenApartmentPage(Apartment apartment)
        {
            return new ApartmentPage(apartment);
        }

        public RegistrationPage OpenRegistrationPage()
        {
            return new RegistrationPage();
        }

        public SignInPage OpenSignInPage()
        {
            return new  SignInPage();
        }

        public SearchPage OpenSearchPage()
        {
            return new SearchPage();
        }
    }
}