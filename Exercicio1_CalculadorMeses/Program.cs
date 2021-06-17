using System;

namespace Exercicio1_CalculadorMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Meses!");

            Console.WriteLine("Digite o valor em meses: ");

            string meses = Console.ReadLine();
            int mesesCalculos = Convert.ToInt32(meses);

            double resultado = mesesCalculos * 30;

            Console.WriteLine("O valor em dias é: " + resultado);

        }
    }
}
