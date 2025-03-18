
using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite as 3 notas de {nomes[i]}:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
            }

            
            medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
        }

      
        Console.WriteLine("\nRelatório de alunoss:");
        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = medias[i] >= 7.0 ? ConsoleColor.Blue : ConsoleColor.Red;

            Console.WriteLine($"Nome: {nomes[i]}, Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]}, Média: {medias[i]} - " +
                              (medias[i] >= 7.0 ? "Aprovado" : "Reprovado"));
        }

        Console.ResetColor();
    }
}