
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
bool rodando = true;
while (rodando)
{
    Console.WriteLine("Qual ação deseja realizar: \n" +
        "1-Adicionar funcionario \n" +
        "2- Remover funcionario\n" +
        "3- Ver lista de funcionarios\n" +
        "4- Adicionar contrato para funcionario\n" +
        "5- Remover contrato para funcionario\n" +
        "6- Ganho do funcionario no mês e ano digitado\n" +
        "7- Sair");
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
            Console.WriteLine("Funcionario adicionado");

            break;

        case 2:
            Console.WriteLine("Digite o numero do funcionario: ");
            int numFunc = int.Parse(Console.ReadLine());
            workers.RemoveAt(numFunc);
            Console.WriteLine("Funcionario removido");
            break;
        case 3:
            //foreach (Worker i in workers)
            //{
                //Console.WriteLine($"Departamento: {i.Departament} | Nome: {i.Name} |  Nivel: {i.Level} | Salario: {i.BaseSalary} | Contratos: {i.Contracts}");
            //}
            for (int i = 0; i < workers.Count; i++)
            {
           
                Console.WriteLine($"Id: {i} | Departamento: {workers[i].Departament.Name} | Nome: {workers[i].Name} |  Nivel: {workers[i].Level} | Salario: {workers[i].BaseSalary}");
                Console.WriteLine("Contratos");
                foreach(HourContract contracts in workers[i].Contracts)
                {
                    Console.WriteLine($"Data: {contracts.Date} | Valor por hora: {contracts.ValuePerHour} | Horas: {contracts.Hours}");
                }
            }
            break;

            
        case 4:
            Console.WriteLine("Qual o funcionario que deseja adicionar um contrato (Escreva o id do funcionario): ");
            int numfun = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data do contrato: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora: ");
            double ValuePerhour = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas: ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date,ValuePerhour,hours);
            workers[numfun].addContract(contract);

            Console.WriteLine("Contrato adicionado");
            break;
        
        case 5:
            Console.WriteLine("Qual o funcionario que deseja remover um contrato (Escreva o id do funcionario) ");
            numfun = int.Parse(Console.ReadLine());
            Console.WriteLine($"{workers[numfun].Contracts}");
            
            Console.WriteLine("Digite o numero do contrato que será removido (o primeiro contrato é 0):");
            int c = int.Parse(Console.ReadLine());
            workers[numfun].removeContract(workers[numfun].Contracts[c]);

            Console.WriteLine("Contrato removido");
            break;

        case 6:
            Console.WriteLine("Digite o numero do funcionario: ");
            numfun = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(workers[numfun].Income(year,month));
           
            break;
        case 7:
            rodando = false;
            break;
    }
}
