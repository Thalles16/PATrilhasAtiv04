using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        
        string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
        
        Console.WriteLine("O número " +numero+" é "+resultado);
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
