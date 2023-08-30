using System.Collections.Generic;
using System.Globalization;

namespace Course9Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int qFunc = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < qFunc; i++)
            {
                Console.Write("Insira o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Insira o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Id do funcionario que tera o salario aumentado: ");
            int aumentarSalarioId = int.Parse(Console.ReadLine());
            Funcionario emp = list.Find(x => x.Id == aumentarSalarioId);

            if (emp != null)
            {
                emp.AumentarSalario(10.0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Este id não existe!");
            }

            foreach (Funcionario f in list)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}


