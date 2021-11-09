namespace HW_09.Booking.com.Models
{
    public class Apartment
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int Price { get; private set; }

        public Apartment(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
