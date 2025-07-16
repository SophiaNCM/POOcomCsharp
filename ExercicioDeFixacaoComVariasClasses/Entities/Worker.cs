using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacaoComVariasClasses.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public Enums.WorkerLevel level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
    }
}
