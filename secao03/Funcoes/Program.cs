using System;

namespace Funcoes{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Insira o 1º numero");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o 2º numero");
            int n2 = int.Parse(Console.ReadLine());

            int soma = Soma(n1, n2);

            Console.WriteLine($"Soma: {soma}");
        }

        static int Soma(int n1, int n2){
            return n1 + n2;
        }
    }
}