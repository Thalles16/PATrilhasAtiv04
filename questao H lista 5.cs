using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();
        
        bool entradaValida = int.TryParse(entrada, out int numero);
        string resultado = entradaValida ? ((numero % 2 == 0) ? "Par" : "Ímpar") : "Entrada inválida";
        
        Console.WriteLine(resultado);
        Console.ReadKey();
    }
}
