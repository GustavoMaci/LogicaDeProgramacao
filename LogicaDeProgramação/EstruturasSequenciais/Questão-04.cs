using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_04_Sequenciais
    {
        static void Main(string[] args)
        {

            int x, y, soma;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
