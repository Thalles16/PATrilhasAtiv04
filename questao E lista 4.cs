class Program
{
    static void Main()
    {
        
        Console.WriteLine("Qual o seu nome ?");
        string nome = (Console.ReadLine()).ToLower();

       
        Console.WriteLine("Qual a sua idade?");
        int idade = int.Parse(Console.ReadLine());
        
        if (nome.Length > 3 && idade >= 18)
        {
            Console.WriteLine("O Acesso foi permitido!");
        }
        else
        {
            Console.WriteLine("Acesso Negado.");
        }

        Console.WriteLine("Aperte qualquer tecla para sair...");
        Console.ReadKey();
    }
}
