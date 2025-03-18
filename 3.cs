using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 5]; 
        int numLinhas = matriz.GetLength(0);
        int numColunas = matriz.GetLength(1);

        
        Console.WriteLine("Digite 15 números inteiros para a matriz:");
        for (int i = 0; i < numLinhas; i++)
        {
            for (int j = 0; j < numColunas; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

       
        Console.WriteLine("\nSoma dos valores de cada linha:");
        for (int i = 0; i < numLinhas; i++)
        {
            int soma = 0;
            for (int j = 0; j < numColunas; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Soma da linha {i + 1}: {soma}");
        }
    }
}