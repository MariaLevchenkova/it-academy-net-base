namespace HW_03
{
    internal class TeamLeader: Engineer
    {
        private List<string> responsibilities;
        public TeamLeader(
           string firstName,
           string lastName,
           string gitHub,
           int experience,
           List<string> technologies)
           : base(firstName, lastName, gitHub, experience, technologies)
        
        {
            responsibilities = new List<string>
            {
                "1.English",
                "2. Наставничество",
                "3. Архитектура, шаблоны проектирования ",
                "4. Постановка целей и оценка прогресса",
                "5. Развитие компетенций",
                "6. Разрешение конфликтов"
            };
        }
        public override List<string> Responsibilities => responsibilities;
        
        protected override int SalaryCoefficient =>8;

        protected override int Bonus =>500;
    }
}
