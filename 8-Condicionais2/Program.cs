using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            //valor booleando armazena apenas dois valores: VERDADEIRO ou\e FALSO.
            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");

            }





            Console.ReadLine();
        }
    }
}
