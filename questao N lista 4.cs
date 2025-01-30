using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine(); // Lê a entrada do usuário

        bool naoEhVazia = !string.IsNullOrWhiteSpace(palavra); // Verifica se a string não está vazia ou só tem espaços

        if (naoEhVazia)
        {
            Console.WriteLine("A palavra não é vazia.");
        }
        else
        {
            Console.WriteLine("Você não digitou nenhuma palavra.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
