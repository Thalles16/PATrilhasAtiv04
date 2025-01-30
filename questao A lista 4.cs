class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

       
        Console.WriteLine("Você possui carteira de motorista? (sim/não)");
        string resposta = Console.ReadLine().ToLower(); 

        
        if (idade > 18 && resposta == "sim")
        {
            Console.WriteLine("Você pode dirigir.");
        }
        else
        {
            Console.WriteLine("Você não pode dirigir.");
        }

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}
