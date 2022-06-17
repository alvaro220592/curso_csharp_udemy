using System;

namespace For{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Quandos números vc vai inserir?");
            int qtde = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= qtde; i++){
                Console.WriteLine($"insira o {i}º número");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine($"Soma: {soma}");
        }
    }
}