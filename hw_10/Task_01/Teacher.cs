namespace hw_1
{
    internal class Teacher: Person
    {
        private string subject;

        public Teacher(string subject)
        {
            this.subject = subject;
        }

        public void Explain()
        {
            Console.WriteLine ("Explanation  begins.");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello from teacher " );
        }
    }
}
