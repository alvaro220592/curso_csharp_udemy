using System;
using System.Globalization;

namespace Aluno{
    class Program{
        static void Main(String[] args){
            Aluno a = new Aluno();

            Console.WriteLine("Insira a 1ª nota");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Insira a 2ª nota");
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Insira a 3ª nota");
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.CalcMedia();

            Console.WriteLine($"Media final: {a.Media.ToString("F2", CultureInfo.InvariantCulture)}");

            a.CalcResultado();

            Console.WriteLine(a);

        }
    }
}