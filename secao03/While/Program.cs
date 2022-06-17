using System;
using System.Globalization;

namespace While{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Insira um nº");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // int cont = 0;
            // double raiz = Math.Sqrt(x);
            // Console.WriteLine($"Raíz quadrada: {raiz.ToString("F3", CultureInfo.InvariantCulture)}");

            // while(cont < 4){

            // }

            while(x > 0){
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz: {raiz.ToString("F3", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Insira outro nº");
                x = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo");
        }
    }
}