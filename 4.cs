using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int contador = 1;

       
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = contador++;
            }
        }

       
        Console.WriteLine("Valores das diagonais da matriz:");
        Console.WriteLine("Diagonal principal:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.WriteLine("\nDiagonal secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, 4 - i] + " ");
        }
    }
}