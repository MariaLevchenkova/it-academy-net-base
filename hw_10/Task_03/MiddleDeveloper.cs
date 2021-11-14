using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class MiddleDeveloper:Engineer
    {
        public MiddleDeveloper (
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
                "2.OOP",
                "3.ASP.NET",
                "4.Проводить код-ревью",
                "5.Язык программирования C#",
            };
        }
        private List<string> responsibilities;

        public override List<string> Responsibilities => responsibilities;

        protected override int SalaryCoefficient => 3;

        protected override int Bonus => 0;
    }
}
