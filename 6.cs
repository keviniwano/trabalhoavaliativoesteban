using System;

class Program
{
    static char[,] tabuleiro = new char[3, 3];
    static int jogadorAtual = 1;

    static void Main()
    {
        InicializaTabuleiro();
        while (true)
        {
            ExibeTabuleiro();
            FazJogada();
            if (VerificaVencedor())
            {
                ExibeTabuleiro();
                Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                break;
            }
            if (VerificaEmpate())
            {
                ExibeTabuleiro();
                Console.WriteLine("Empate!");
                break;
            }
            jogadorAtual = (jogadorAtual == 1) ? 2 : 1; 
        }
    }

    static void InicializaTabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }

    static void ExibeTabuleiro()
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(" " + tabuleiro[i, 0] + " | " + tabuleiro[i, 1] + " | " + tabuleiro[i, 2]);
            if (i < 2) Console.WriteLine("---|---|---");
        }
    }

    static void FazJogada()
    {
        int linha, coluna;
        char simbolo = (jogadorAtual == 1) ? 'X' : 'O';

        while (true)
        {
            Console.WriteLine($"Jogador {jogadorAtual} ({simbolo}), digite sua jogada (linha e coluna): ");
            linha = int.Parse(Console.ReadLine()) - 1;
            coluna = int.Parse(Console.ReadLine()) - 1;

            if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = simbolo;
                break;
            }
            else
            {
                Console.WriteLine("Jogada inválida! Tente novamente.");
            }
        }
    }

    static bool VerificaVencedor()
    {
        char simbolo = (jogadorAtual == 1) ? 'X' : 'O';

          
        return (VerificaLinhas(simbolo) || VerificaColunas(simbolo) || VerificaDiagonais(simbolo));
    }

    static bool VerificaLinhas(char simbolo)
    {
        for (int i = 0; i < 3; i++)
            if (tabuleiro[i, 0] == simbolo && tabuleiro[i, 1] == simbolo && tabuleiro[i, 2] == simbolo)
                return true;
        return false;
    }

    static bool VerificaColunas(char simbolo)
    {
        for (int i = 0; i < 3; i++)
            if (tabuleiro[0, i] == simbolo && tabuleiro[1, i] == simbolo && tabuleiro[2, i] == simbolo)
                return true;
        return false;
    }

    static bool VerificaDiagonais(char simbolo)
    {
        return (tabuleiro[0, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 2] == simbolo) ||
               (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo);
    }

    static bool VerificaEmpate()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (tabuleiro[i, j] == ' ')
                    return false;
        return true;
    }
}