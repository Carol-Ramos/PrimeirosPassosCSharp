using System;

namespace _10_CalculaPoupaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 10 - Calcula Poupança");
            Console.WriteLine("");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                Console.WriteLine("");

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
