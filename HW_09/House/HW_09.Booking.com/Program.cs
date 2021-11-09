using HW_09.Booking.com.Models;

namespace HW_09.Booking.com
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("mail@gmail.com", "Pa$$w0rd");
            Browser browser = new Browser();

            browser.OpenNewWindow();
            BookingSite site = browser.OpenBookingDotCom();

            if (!user.IsRegisteredOnBookingDotCom)
            {
                RegistrationPage registrationPage = site.OpenRegistrationPage();

                registrationPage.SetEmail(user.Email);
                registrationPage.SetPassword(user.Password);
                registrationPage.Register();
                user.IsRegisteredOnBookingDotCom = true;
            }

            if (!site.IsUserSignedIn)
            {
                SignInPage signInPage = site.OpenSignInPage();

                signInPage.SetLogin(user.Email);
                signInPage.SetPassword(user.Password);
                signInPage.SignIn();
            }

            SearchPage searchPage = site.OpenSearchPage();

            searchPage.SetSity("Milan");
            searchPage.SetAdultCount(2);
            searchPage.SetChildrenCount(0);
            searchPage.SetRoomCount(1);

            Apartment bookingApartment;
            do
            {
                searchPage.SetCheckInDate("12/30/2021");
                searchPage.SetCheckOutDate("01/05/2021");

                Apartment[] aparments = searchPage.Search();

                bookingApartment = user.SelectApartment(aparments);
            }
            while (bookingApartment == null);

            ApartmentPage apartmentPage = site.OpenApartmentPage(bookingApartment);
            apartmentPage.Reserve();
        }
    }
}
