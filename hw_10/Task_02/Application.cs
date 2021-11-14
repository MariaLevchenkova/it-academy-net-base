namespace Task_02
{
    public class Application : Item
    {
        public Application(string name, string code, string category, int size) : base(name, code, category, size)
        {
        }

        public override void Play()
        {
            Console.WriteLine("Application Data: " + ToString());
        }
    }
}
