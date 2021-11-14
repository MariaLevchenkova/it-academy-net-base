namespace HW_03
{
    internal class JuniorDeveloper : Engineer
    {
        private List<string> responsibilities;

        public JuniorDeveloper(
            string firstName,
            string lastName,
            string gitHub,
            int experience,
            List<string> technologies)
            : base(firstName, lastName, gitHub, experience, technologies)
        {
            responsibilities = new List<string>
            {
                "1. English",
                "2. Основы программирования",
                "3. Язык программирования C#",
                "4. OOP",
                "5. ASP.NET"
            };
        }

        public override List<string> Responsibilities => responsibilities;

        protected override int SalaryCoefficient => 1;

        protected override int Bonus => 0;
    }
}
