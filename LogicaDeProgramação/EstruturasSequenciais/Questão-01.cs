using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_01
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a largura de um terreno: ");
            double largura = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor do metro quadrado: ");
            double valor = double.Parse(Console.ReadLine(), CI);

            double area_terreno = largura * comprimento;
            double preco = area_terreno * valor;

            Console.WriteLine($"Area do terreno = {area_terreno.ToString("F2", CI)}");
            Console.WriteLine($"Preco do terreno = {preco.ToString("F2", CI)}");
        }
    }
}
