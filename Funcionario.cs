using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course9Exerc
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double p)
        {
            Salario += Salario * p / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario}";
        }
    }
}
