using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantos funcionarios deseja cadastrar ? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(nome, salario, id));
                Console.WriteLine();

            }

            Console.WriteLine("Entre com o Id do funcionario em que deseja icrementar o salário: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("id não cadastrado: ");
            }


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");

            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }



        }
    }
}
