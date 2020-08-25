using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do funcionário:");
            Console.Write("Nome: ");
            f1.name = Console.ReadLine();
            Console.Write("Salário: ");
            f1.sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do outro funcionário:");
            Console.Write("Nome: ");
            f2.name = Console.ReadLine();
            Console.Write("Salário: ");
            f2.sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (f1.sal + f2.sal) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
