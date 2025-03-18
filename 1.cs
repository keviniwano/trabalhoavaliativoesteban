using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[15];

        
        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 0; i < 15; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

         
        Console.WriteLine("Números nas posições pares:");
        for (int i = 0; i < 15; i += 2)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}