using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("deseja comprar um produto");
        string resposta = (Console.ReadLine().ToLower());
        
		
        if (resposta == "sim" || resposta == "s" )
        {
        	Console.WriteLine("agradecemos a preferencia, obrigado pela compra");
        	
        }
        else
        {
        	
        	Console.WriteLine("agradecemos pela atenção, volte sempre");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
