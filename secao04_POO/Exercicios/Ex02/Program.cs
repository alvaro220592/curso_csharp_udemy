using System;
using System.Globalization;

namespace Ex02{
    class Program{
        static void Main(String[] args){
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            a.Salario = EntradaSalario();
            b.Salario = EntradaSalario();

            double media = (a.Salario + b.Salario) / 2;

            Console.WriteLine($"A média é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double EntradaSalario(){
            Console.WriteLine("Insira o salário");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return sal;
        }
    }
}