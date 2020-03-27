using System;
using System.Globalization;

namespace LerTeclado {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com o preço de um produto:");
            float produto = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');

            string lastName = v[0];
            int idade = int.Parse(v[1]);
            float altura = float.Parse(v[2],CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("You said: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
