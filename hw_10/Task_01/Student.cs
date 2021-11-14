namespace hw_1
{
    internal class Student: Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge ()
        {
            string result= $"My age is {Age} years old";
            Console.WriteLine(result);
        }

        public override void Hello()
        {
            Console.WriteLine($"Hello from student and I am {Age}");
        }
    }
}

     
   

