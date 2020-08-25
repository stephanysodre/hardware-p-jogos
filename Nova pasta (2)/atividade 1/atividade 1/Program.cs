using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa n1 = new pessoa();
            pessoa n2 = new pessoa();

            Console.WriteLine("insira seus dados: ");
            Console.WriteLine("nome: ");
            n1.name = Console.ReadLine();
            Console.WriteLine("idade: ");
            n1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("insira os dados da outra pessoa: ");
            Console.WriteLine("nome: ");
            n2.name = Console.ReadLine();
            Console.WriteLine("idade: ");
            n2.age = int.Parse(Console.ReadLine());

            if (n1.age > n2.age)
            {
                Console.WriteLine("o mais velho é: " + n1.name);
            }
            else
            {
                Console.WriteLine("o mais velho é: " + n2.name);
            }
        }
    }
}
