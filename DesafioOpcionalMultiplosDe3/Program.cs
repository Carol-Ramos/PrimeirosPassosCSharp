using System;

namespace DesafioOpcionalMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio opcional: Múltiplos de 3");
            Console.WriteLine();

            for (int multiplo = 0; multiplo <= 100; multiplo++)
            {
               if (multiplo % 3 == 0)
                {
                    Console.Write(", " + multiplo);
                }
            }

            Console.ReadLine();
        }
    }
}
