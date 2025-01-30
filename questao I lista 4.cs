using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("escreva seu nome");
        string nome = (Console.ReadLine().ToLower());
        
		
        if (nome == "Wilson" || nome == "Gloria" )
        {
        	Console.WriteLine("seja bem vindo(a) de volta!");
        	
        }
        else
        {
        	
        	Console.WriteLine("ola novo usuario(a), seja bem vindo!");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
