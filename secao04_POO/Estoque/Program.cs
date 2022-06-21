using System;
using System.Globalization;

namespace Estoque{
    class Program{
        static void Main(String[] args){
            
            Product p = new Product();

            Console.WriteLine("Insira os dados do produto.");
            
            Console.WriteLine("Nome:");
            p.Name = Console.ReadLine();

            Console.WriteLine("Preço:");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(p);

            Console.WriteLine("Insira a quantidade a ser adicionada ao estoque");
            int quantidadeAdd = int.Parse(Console.ReadLine());

            p.AddProduct(quantidadeAdd);
            Console.WriteLine(p);

            Console.WriteLine("Insira a quantidade a ser removida ao estoque");
            int quantidadeRm = int.Parse(Console.ReadLine());
            p.RemoveProduct(quantidadeRm);

            Console.WriteLine(p);
        }
    }
}