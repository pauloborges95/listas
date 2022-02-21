using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioLista
{
    class Employee
    {
        public string Nome { get; set; }
        public double Salario { get; private set; }
        public int Id { get; set; }

        public Employee(string nome, double salario, int id)
        {
            Nome = nome;
            Salario = salario;
            Id = id;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return Id
                +", "
                + Nome
                +", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
