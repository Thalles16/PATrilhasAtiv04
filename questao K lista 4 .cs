using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("voce é um robo?");
        string resposta = (Console.ReadLine());
        
        if (resposta == "não")
        {
        	Console.WriteLine("prove que voce não é um robo");
        }
        else
        {
        	Console.WriteLine("acesso negado");
        }

       

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
