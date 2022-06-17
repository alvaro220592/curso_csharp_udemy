using System;

namespace Ex01{
    class Program{
        static void Main(String[] args){
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            string nomeA = EntradaNome(a.Nome);
            int idadeA = EntradaIdade(a.Idade);

            string nomeB = EntradaNome(b.Nome);
            int idadeB = EntradaIdade(b.Idade);

            string older = idadeA > idadeB ? nomeA : nomeB;

            Console.WriteLine($"Pessoa mais velha: {older}");
        }

        static string EntradaNome(string nome){
            Console.WriteLine("Insira o nome");
            nome = Console.ReadLine();

            return nome;
        }

        static int EntradaIdade(int idade){            
            Console.WriteLine("Insira a idade");
            idade = int.Parse(Console.ReadLine());

            return idade;
        }
    }
}