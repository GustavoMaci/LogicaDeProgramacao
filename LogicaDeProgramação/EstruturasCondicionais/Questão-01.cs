using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_01_Condicionais
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);

            double media = nota1 + nota2;

            Console.WriteLine($"Nota Final: {media.ToString("F2", CI)}");

            if (media < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }
            
        }
    }
}
