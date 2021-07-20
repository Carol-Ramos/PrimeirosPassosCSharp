using System;

namespace _3_NovoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 23;

            Console.WriteLine("Olá, novo teste!");
            Console.WriteLine(idade);
            Console.WriteLine("Tecle enter para continuar.");
            Console.ReadLine();

            idade = 23 + 5;
            Console.WriteLine("Sua idade daqui 5 anos será: " + idade + " anos.");

            idade = 23 - 5;
            Console.WriteLine("Sua idade há cinco anos era " + idade + " anos.");

            idade = 23 * 5;
            Console.WriteLine("Sua idade multiplicado por 5 é " + idade);

            Console.WriteLine("Programa finalizado. Tecle enter para sair...");
        }
    }
}
