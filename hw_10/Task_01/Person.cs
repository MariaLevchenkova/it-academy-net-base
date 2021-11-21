namespace hw_1
{
    internal class Person
    {
        protected int Age;

        public void SetAge(int age) 
        {
            this.Age = age;
        }

        public virtual void Hello()
        {
            Console.WriteLine("Hello from person");
        }
    }  
}
