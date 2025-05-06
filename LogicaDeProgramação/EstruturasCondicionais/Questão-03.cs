using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_03_Condicionais
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Primeiro Valor: ");
            int valor_01 = int.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            int valor_02 = int.Parse(Console.ReadLine());

            Console.Write("Terceiro Valor: ");
            int valor_03 = int.Parse(Console.ReadLine());

            int menor = 0;

            if (valor_01 < valor_02 && valor_01 < valor_03)
            {
                menor = valor_01;
            }
            else if (valor_02 < valor_03)
            {
                menor = valor_02;
            }
            else
            {
                menor = valor_03;
            }

            Console.WriteLine($"Menor: {menor}");

        }
    }
}
