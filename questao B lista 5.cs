using System;

class Program
{
    static void Main()
    {
    	Console.WriteLine("Digite um número:");
    	int num1 = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Digite outro número:");
    	int num2 = Convert.ToInt32(Console.ReadLine());
    	
    	int maior = (num1 > num2) ? num1 : num2;

	Console.WriteLine("O maior número é " + maior);
	Console.ReadKey();
     }
 }
