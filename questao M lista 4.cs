using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Você faz parte de um Clube? (sim/não)");
        string resposta = Console.ReadLine().ToLower(); // Converte para minúsculas para evitar erros de comparação

        if (resposta == "sim")
        {
            Console.WriteLine("Você é um membro ativo ou inativo do Clube? (ativo/inativo)");
            string status = Console.ReadLine().ToLower();

            if (status == "inativo")
            {
                Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo de todos os benefícios do clube.");
            }
            else
            {
                Console.WriteLine("Ótimo! Continue aproveitando os benefícios do nosso clube.");
            }
        }
        else
        {
            Console.WriteLine("Obrigado pelo seu tempo.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
