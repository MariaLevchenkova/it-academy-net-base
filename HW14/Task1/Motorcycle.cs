using Task1;

public class Motorcycle : IItem
{
    public string Name {get; set;}
    public string Model {get; set;}
    public int Id {get; set;}
    public int Odometer {get; set;}
    public int Year {get; set;}

    public override string ToString()
    {
        return $"Id {Id}, Name {Name}, Model {Model}, Odometer {Odometer}, Year {Year}";
    }
}