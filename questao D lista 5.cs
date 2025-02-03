using System;

class Program
{
    static void Main()
    {
        string palavras = Console.ReadLine();
	string resultado = (string.IsNullOrEmpty(palavras)) ? "String vazia" : "String não vazia";
	Console.WriteLine(resultado);

        Console.ReadKey();
    }
}
