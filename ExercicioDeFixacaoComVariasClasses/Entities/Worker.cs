using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioDeFixacaoComVariasClasses.Entities.Enums;

namespace ExercicioDeFixacaoComVariasClasses.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public Enums.WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract) { Contracts.Remove(contract); }

        public string Income(int year, int month) {

            double sum = BaseSalary;

            foreach (HourContract contract in Contracts) { 
            if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return $"O total ganho nessa epoca é: {sum}" ;
        }
    }
}
