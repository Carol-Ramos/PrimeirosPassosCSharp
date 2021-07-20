//João gostaria de criar um programa sobre Imposto de Renda (IR)
//e verificou as regras de alíquota. Ele descobriu no site da receita:
//* De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
//* De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
//* De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$636.


using System;

namespace Atividade2_CalcularIR
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario > 1900 && salario <= 2800)
            {
                double valor = 142.0;
                Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$" + valor+ " reais.");
            }
            if (salario >2800 && salario <= 3751.0)
            {
                double valor = 350;
                Console.WriteLine("O IR é de 15% e pode deduzir R$" + valor);
            }
            if (salario >3751.01 && salario < 1664.00)
            {
                double valor = 636;
                Console.WriteLine("O IR é de 22.5% e pode deduzir R$" + valor);
            }



            Console.ReadLine();
        }
    }
}
