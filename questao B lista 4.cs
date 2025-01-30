using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("voce deseja comprar um carro novo ?");
        string resposta = (Console.ReadLine()).ToLower();

       
        Console.WriteLine("Você possui dinheiro suficiente para isto? (sim/não)");
        string dinheiro = Console.ReadLine(); 

        
        if (resposta == "sim" && dinheiro == "sim")
        {
            Console.WriteLine("parabens voce pode comprar um carro novo!");
        }
        else
        {
            Console.WriteLine("Você não pode comrar um carro novo.");
        }

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}
