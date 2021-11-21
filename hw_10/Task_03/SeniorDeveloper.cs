using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class SeniorDeveloper:Engineer
    {
        private List<string> responsibilities;

        public SeniorDeveloper(
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
                "2. Алгоритмы",
                "3. Архитектура, шаблоны проектирования ",
                "4. Базы данных",
                "5. Параллельное выполнение и синхронизация работы процессов",
                "6. Основы производительности ПО",
            };
        }

        public override List<string> Responsibilities => responsibilities;
        protected override int SalaryCoefficient => 5;
        protected override int Bonus =>300;
    }
}
