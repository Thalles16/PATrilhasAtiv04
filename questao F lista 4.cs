using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Você deseja um café? (sim/não)");
        string cafe = Console.ReadLine().ToLower();

        if (cafe == "sim")
        {
            Console.WriteLine("Você deseja adicionar açúcar ao seu café? (sim/não)");
            string acucar = Console.ReadLine().ToLower();

            Console.WriteLine("Você deseja adicionar leite ao seu café? (sim/não)");
            string leite = Console.ReadLine().ToLower();

           
            if (acucar == "sim" || leite == "sim")
            {
                Console.WriteLine("Café com adicional está pronto!");
            }
            else
            {
                Console.WriteLine("Café simples preparado...");
            }
        }
        else
        {
            Console.WriteLine("Ok! Sem café para você.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
