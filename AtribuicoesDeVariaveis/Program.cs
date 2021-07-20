using System;

namespace AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 23;
            int idadeCarol = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeCarol);


            Console.ReadLine();
        }
    }
}
