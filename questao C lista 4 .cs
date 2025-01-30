using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("voce possui um diploma de ensino superior ?");
        string resposta = (Console.ReadLine()).ToLower();

       
        Console.WriteLine("Você tem mais de 21 anos ?");
        string respostaIdd = (Console.ReadLine());

        
        if (resposta == "sim" && respostaIdd == "sim")
        {
            Console.WriteLine("Parabens voce esta qualificado para vaga!");
        }
        else
        {
            Console.WriteLine("Voce nao esta qualificado para a vaga, volte quando for qualificado.");
        }

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}
