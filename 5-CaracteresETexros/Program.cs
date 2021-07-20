using System;

namespace _5_CaracteresETexros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //char de character - inglês. A variável char é guardado como um número na memória do computador, só que com 16bits
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //String é para colocar texto e para isso usa aspas duplas
            string titulo = "Alura Cursos de tecnologia " + 20;
            string cursosProgramacao = @" 
                 - .NET 
                 - Java 
                 - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
