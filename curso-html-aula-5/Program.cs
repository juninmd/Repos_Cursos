using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Ola mundo!");
            // Console.WriteLine("Digite um numero! ->");
            // var numero = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Seu numero e: {numero}");
            var calculos = new string[] { "adicao", "subtracao" };
            Contas.Efetuar(calculos);
        }
    }
}
