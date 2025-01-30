using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine()); 

        bool naoEhZero = numero != 0; 

        if (naoEhZero == true) 
        {
            Console.WriteLine("O número é diferente de zero.");
        }
        else
        {
        	Console.WriteLine("O número escolhido é Zero!");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
