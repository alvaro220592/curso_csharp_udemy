using System;
using System.Globalization;

namespace Triangulo{
    class Program{
        static void Main(String[] args){

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Insira as medidas do x");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira as medidas do y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área do triângulo 1: {areaX.ToString("F2", CultureInfo.InvariantCulture)}\nÁrea do triângulo 2: {areaY.ToString("F2", CultureInfo.InvariantCulture)}");
            
            if(areaX > areaY){
                Console.WriteLine("O triângulo 1 têm maior área");
            }else{
                Console.WriteLine("O triângulo 2 têm maior área");
            }
        }

        static void EntradaMedidas(double ladoA, double ladoB, double ladoC){
            Console.WriteLine($"Insira as 3 medidas do triângulo");

            Console.WriteLine("Lado A");
            ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Lado B");
            ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Lado C");
            ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}