using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_03
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string nome_1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string nome_2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade_2 = int.Parse(Console.ReadLine());

            double idade_media = (idade_1 + idade_2) / 2.0;

            Console.WriteLine($"A idade média de {nome_1} e {nome_2} é de {idade_media.ToString("F1", CI)}");
        }
    }
}
