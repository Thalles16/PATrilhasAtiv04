using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("diga um numero");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero < 0 || numero > 10)
        {
        	Console.WriteLine("numero invalido");
        }
        else
        {
        	Console.WriteLine("numero valido");
        }

       

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
