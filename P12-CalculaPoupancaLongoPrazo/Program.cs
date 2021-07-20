using System;

namespace P12_CalculaPoupancaLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 12");
            Console.WriteLine("");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;


            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
   //O for oferece uma forma de declaração mais enxuta, onde precisamos informar dentro dos parêntes
   //do for a inicialização da variável que irá servir de auxiliar para a condição de parada, a 
   //condição de parada que deve ser verificada como verdadeira para que o laço seja executado
   //e, por fim, a atualização do valor da variável auxiliar.