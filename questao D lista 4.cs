using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("voce possui assinatura na netflix ?");
        string resposta1 = (Console.ReadLine()).ToLower();

       
        Console.WriteLine("Você ja assistiu stranger things?");
        string resposta2 = (Console.ReadLine());

        
        if (resposta1 == "sim" && resposta2 == "sim")
        {
            Console.WriteLine("otimo, agora voce pode assistir a segunda temporada!");
        }
        else
        {
            Console.WriteLine("PAIA, sem segunda temporada pra voce.");
        }

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}
