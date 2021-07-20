using System;

namespace LacoDeRepeticaoForTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Laço de Repetição For: Tabuada");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
            } 


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tecle enter duas vezes para sair...");
            Console.ReadLine();
        }
    }
}
