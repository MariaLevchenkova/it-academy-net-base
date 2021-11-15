namespace HW_09.Booking.com.Models
{
    public class SearchPage
    {
        public void SetSity(string sity)
        {
        }

        public void SetAdultCount(int persons)
        {
        }

        public void SetChildrenCount(int children)
        {
        }

        public void SetRoomCount(int room)
        {
        }

        public void SetCheckInDate(string inDate)
        {
        }

        public void SetCheckOutDate (string outDate)
        {
        }

        public Apartment[] Search()
        {
            Apartment[] apartments = new Apartment[] 
            {
                new Apartment(1, "Super Apartment", 100),
                new Apartment(2, "Super Puper Apartment", 200),
                new Apartment(3, "Super Puper Duper Apartment", 300),
            };
            return apartments;
        }
    }
}
