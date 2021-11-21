namespace HW_03
{
    internal abstract class Engineer
    {
        private Guid id = Guid.NewGuid();
        private const int BaseSalary = 500;

        protected Engineer(
            string firstName,
            string lastName,
            string gitHub,
            int experience,
            List<string> technologies)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            Technologies = technologies;
            GitHub = gitHub;
        }

        public Guid Id => id;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Experience { get; set; }

        public abstract List<string> Responsibilities { get; }

        public List<string> Technologies { get; set; }

        public string GitHub { get; set; }

        public int GetSalary()
        {
            return SalaryCoefficient * BaseSalary + Bonus;
        }

        protected abstract int SalaryCoefficient { get; }

        protected abstract int Bonus { get; }
    }
}
