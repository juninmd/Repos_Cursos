using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Contas
    {
        public static void Efetuar(string[] args)
        {
            Console.WriteLine("---- Contas ----\n");
            Console.WriteLine("Digite o numero a:");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero b:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("---- Resultados ----");

            if (args == null || args.ToList().Contains("adicao"))
                Console.WriteLine($"Adicao: {a + b}");
            if (args == null || args.ToList().Contains("subtracao"))
                Console.WriteLine($"Subtracao: {a - b}");

            if (args == null || args.ToList().Contains("multiplicacao"))
                Console.WriteLine($"Multiplicacao: {a * b}");

            if (args == null || args.ToList().Contains("divisao"))
                Console.WriteLine($"Divisao: {a / b}");

        }
    }
}
