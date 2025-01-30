using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("diga um numero");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero % 3 == 0 || numero % 5 == 0)
        {
        	Console.WriteLine("o numero e divisivel por 3 ou 5");
        }
        else
        {
        	Console.WriteLine("o numero nao e divisivel por 3 ou 5");
        }

       

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
