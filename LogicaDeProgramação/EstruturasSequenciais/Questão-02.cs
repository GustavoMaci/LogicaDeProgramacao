using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Questao_02
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Base do retangulo: ");
            double Base = double.Parse(Console.ReadLine(), CI);

            Console.Write("Altura do retangulo: ");
            double Altura = double.Parse(Console.ReadLine(), CI);

            double Area = Base * Altura;
            double Perimetro = Base * 2 + Altura * 2;
            double Diagonal = Math.Sqrt(Altura * Altura + Base * Base);

            Console.WriteLine($"AREA = {Area.ToString("F4", CI)}");
            Console.WriteLine($"Perimetro = {Perimetro.ToString("F4", CI)}");
            Console.WriteLine($"DIAGONAL = {Diagonal.ToString("F4", CI)}");
        }
    }
}
