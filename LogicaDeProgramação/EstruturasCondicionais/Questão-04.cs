using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_04_Condicionais
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            double novo_preco = 0;

            if (minutos <= 100)
            {
                novo_preco = 50.0;
            }
            else
            {
                novo_preco = (minutos - 100) * 2.0 + 50.0;
            }

            Console.WriteLine($"Valor a pagar: R$ {novo_preco.ToString("F2", CI)}");

        }
    }
}
