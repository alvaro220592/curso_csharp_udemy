using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(String[] args)
        {
            // string[] cores = Console.ReadLine().Split(' ');
            // string cor1 = cores[0];
            // string cor2 = cores[1];
            // string cor3 = cores[2];

            // Console.WriteLine($"{cor1} {cor2} {cor3}");

            // Console.WriteLine("===============================");

            // try
            // {
            //     int n1 = int.Parse(Console.ReadLine());
            //     char ch = char.Parse(Console.ReadLine());
            //     float n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            //     Console.WriteLine($"{n1}\n{ch}\n{n2.ToString("F2", CultureInfo.InvariantCulture)}");
            // }
            // catch (System.Exception)
            // {
                
            //     Console.WriteLine("erro");
            // }


            // Console.WriteLine("Insira o nome, sexo, idade e altura");
            // string[] dados = Console.ReadLine().Split(' ');

            // string nome = dados[0];

            // char sexo = char.Parse(dados[1]);
            
            // int idade = int.Parse(dados[2]);

            // float altura = float.Parse(dados[3], CultureInfo.InvariantCulture);

            // Console.WriteLine($"{nome} é do sexo {sexo}, tem {idade} anos e tem {altura.ToString("F2")}m de altura");

            
            // Exercício
            Console.WriteLine("Insira seu nome completo");
            string fullname = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço de um produto");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{fullname}\n{quartos}\nR${preco.ToString("F2")}");


            Console.WriteLine("Insira seu último nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');

            string lastname = dados[0];

            int idade = int.Parse(dados[1]);

            float altura = float.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{lastname} {idade} {altura}");

        }
    }
}