using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacaoComVariasClasses.Entities
{
    internal class HourContract
    {
        public DateTime Date;
        public double ValuePerHour;
        public int Hours;

        public HourContract() { }
        public HourContract (DateTime date, double valuePerhour, int hours)
        {
            Date = date;
            valuePerhour = ValuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
