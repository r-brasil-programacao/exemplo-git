using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Soma();
        }

        static void Soma()
        {
            System.Console.WriteLine("******* Soma ****** ");
            System.Console.WriteLine("Digite o primeiro input: ");
            var n1Input = Console.ReadLine();
            System.Console.WriteLine("Digite o segunda input: ");
            var n2Input = Console.ReadLine();


            int n1 = int.Parse(n1Input);
            int n2 = int.Parse(n2Input);

            int resultado = n1 + n2;
            System.Console.WriteLine("Resultado da Soma é: " + resultado);
        }
    }
}
