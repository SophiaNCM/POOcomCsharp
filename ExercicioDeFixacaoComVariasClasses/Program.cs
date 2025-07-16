
using System.Collections.Generic;
using ExercicioDeFixacaoComVariasClasses.Entities;
using ExercicioDeFixacaoComVariasClasses.Entities.Enums;

List<Worker> workers = new List<Worker>();
Console.WriteLine("Bem vindo ao sistema de gerenciamento de funcionario!! \n Qual ação deseja realizar: \n" +
    "1- Adicionar funcionarios \n" +
    "2- Sair \n");
int Opcao = int.Parse(Console.ReadLine());

switch (Opcao)
{
    case 1:
        WorkerLevel level;
        level = WorkerLevel.Junior;
        Console.WriteLine("Digite o nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite o nivel do funcionario (junior | pleno/ middle level | senior): ");
        string levelName= Console.ReadLine();
        if(levelName == "junior")
        {
            level = WorkerLevel.Junior;
        }
        else if (levelName =="pleno" || levelName == "middle Level")
        {
            level = WorkerLevel.Md_Level;
        }
        else
        {
            level = WorkerLevel.Senior;
        }

        Console.WriteLine("Digite o salario base: ");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o departamento em que o funcionario trabalha: ");
        string DepartamentName= Console.ReadLine();
        Departament departament = new Departament(DepartamentName);

        Worker worker = new Worker(name,level,salary, departament);

        workers.Add(worker);

    break;

    case 2:
        break;

}

while (true)
{
    Console.WriteLine("Qual ação deseja realizar: \n" +
        "1-Adicionar funcionario \n" +
        "2- Remover funcionario\n" +
        "3- Ver lista de funcionarios\n" +
        "4- Adicionar contrato para funcionario\n" +
        "5- Remover contrato para funcionario\n" +
        "6-Ganho do funcionario no mês e ano digitado");
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            WorkerLevel level;
            level = WorkerLevel.Junior;
            Console.WriteLine("Digite o nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o nivel do funcionario (junior | pleno/ middle level | senior): ");
            string levelName = Console.ReadLine();
            if (levelName == "junior")
            {
                level = WorkerLevel.Junior;
            }
            else if (levelName == "pleno" || levelName == "middle Level")
            {
                level = WorkerLevel.Md_Level;
            }
            else
            {
                level = WorkerLevel.Senior;
            }

            Console.WriteLine("Digite o salario base: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o departamento em que o funcionario trabalha: ");
            string DepartamentName = Console.ReadLine();
            Departament departament = new Departament(DepartamentName);

            Worker worker = new Worker(name, level, salary, departament);

            workers.Add(worker);

            break;

        case 2:
            Console.WriteLine("Digite o numero do funcionario: ");
            int numFunc = int.Parse(Console.ReadLine());
            workers.RemoveAt(numFunc);
            break;
        case 3:
            foreach (Worker i in workers)
            {
                Console.WriteLine($"Departamento {i.Departament} | Nome: {i.Name} |  Nivel: {i.Level} | Salario: {i.BaseSalary} | Contratos: {i.Contracts}");
            }
            break;
            
        case 4:
            Console.WriteLine("Qual o funcionario que deseja adicionar um contrato: ");
            int numfun = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data do contrato: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora: ");
            double ValuePerhour = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas: ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date,ValuePerhour,hours);
            workers[numfun].addContract(contract);
            break;
    }
}
