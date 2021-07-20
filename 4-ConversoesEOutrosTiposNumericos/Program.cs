using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        /// <summary>
        /// A variável INT suporta até 32 bits e apenas números inteiros
        /// A variável LONG é um tipo de variável que suporta 64 bits
        /// A variável SHORT é um tipo de variável que suporta 16 bits
        /// A variável FLOAT tem uma precisão muito curta dos números para as casas decimais
        /// CASTING é a forma de dizer ao compilador para converter uma variável DOUBLE em INT --- Assim como mostra no exemplo abaixo
        /// </summary>
        /// <param name="args"></param>
      
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioInteiro;     
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            long idade = 130000000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
