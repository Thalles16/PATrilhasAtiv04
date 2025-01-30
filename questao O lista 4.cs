using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Você não deseja cancelar está operação? (sim/não)");
        string resposta = Console.ReadLine(); // Lê a resposta do usuário

        bool respostaNegativa = resposta != null && resposta.ToLower() == "não"; // Verifica se a resposta é "não"

        if (respostaNegativa)
        {
            Console.WriteLine("Por favor, confirme o cancelamento da operação");
        }
        else
        {
            Console.WriteLine("Operação não cancelada.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
