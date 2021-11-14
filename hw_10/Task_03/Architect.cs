namespace HW_03
{
    internal class Architect:Engineer
    {

        private List<string> responsibilities;

        public Architect(
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
                "2. Прояснение требований к проекту",
                "3. Коммуникация с заказчиком",
                "4. Технологическое исследование и протипирование",
                "5. Архитектура конечного продукта",
            };
        }

        public override List<string> Responsibilities => responsibilities; 
        
        protected override int SalaryCoefficient =>12;

        protected override int Bonus =>1000;
    }
}

