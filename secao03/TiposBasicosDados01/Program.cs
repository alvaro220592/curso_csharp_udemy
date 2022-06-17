using System;
using System.Globalization;

namespace TiposBasicosDados01{
    class Program{
        static void Main(String[] args){
            
            // byte n1 = 255;

            // long n2 = 76876876L;

            // char gender = '\u0041';

            // float nume_float = 99.90f;

            // double num_double = 99.90;

            // string nome = "Maria";
            // nome = "João";

            // object objeto = "Maria";
            
            // int int_min = int.MinValue;

            // int int_max = int.MaxValue;

            // decimal decimal_max = decimal.MaxValue;

            // double valorGasolina = 7.768768;

            // Imprimindo com 2 casas decimais
            // Console.WriteLine(valorGasolina.ToString("F2"));

            // Imprimindo com 2 casas decimais e trocando a vírgula por ponto
            // Console.WriteLine(valorGasolina.ToString("F2", CultureInfo.InvariantCulture));

            // Concatenação:
            // string nome = "Álvaro";
            // int idade = 30;
            // string profissao = "programador";
            // float salario = 1900.565F;

            // com placeholders 
            // Console.WriteLine("{0} tem {1} anos, trabalha como {2} e recebe R${3:F2}", nome, idade, profissao, salario);

            // Com interpolação:
            // Console.WriteLine($"{nome} tem {idade} anos, trabalha como {profissao} e recebe R${salario:F2}");

            // Com concatenação de strings(obsoleto)
            // Console.WriteLine(nome + " tem " + idade + " anos, trabalha como " + profissao + " e recebe R$" + salario.ToString("F2"));

            // Exercício
            // string produto1 = "Computador";
            // string produto2 = "Mesa de escritório";

            // byte idade = 30;
            // int codigo = 5290;
            // char genero = 'M';

            // double preco1 = 2100.0;
            // double preco2 = 650.50;
            // double medida = 53.234567;

            // Console.WriteLine($"Produtos:\n{produto1}, cujo preço é R${preco1:F2}\n{produto2}, cujo preço é R${preco2:F2}\n");
            // Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}\n");
            // Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}\nArredondado(três casas decimais): {medida:F3}\nCom separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

            // float x = 7.5F;
            // double y = x;
            // Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));

            // double a;
            // float b;

            // a = 5.5;
            // b = (float)a;

            // int x = 5;
            // int y = 2;
            // double result = (double)x / y;
            // Console.WriteLine(result);

            // int a = 2, b = 3, c = 5;

            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
        }
    }
}