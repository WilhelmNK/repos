using System;

namespace JogoDaVelha
{
    class Jogo
    {
        private char[,] tabuleiro;
        private char jogadorAtual;
        private int jogadas;

        public Jogo()
        {
            tabuleiro = new char[,]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            jogadorAtual = 'X';
            jogadas = 0;
        }

        public void Iniciar()
        {
            bool jogoAtivo = true;
            while (jogoAtivo)
            {
                Console.Clear();
                ExibirTabuleiro();
                Console.WriteLine($"Jogador {jogadorAtual}, escolha uma posição: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int posicao) && posicao >= 1 && posicao <= 9)
                {
                    if (MarcarPosicao(posicao))
                    {
                        jogadas++;
                        if (VerificarVitoria())
                        {
                            Console.Clear();
                            ExibirTabuleiro();
                            Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                            jogoAtivo = false;
                        }
                        else if (jogadas == 9)
                        {
                            Console.Clear();
                            ExibirTabuleiro();
                            Console.WriteLine("Empate!");
                            jogoAtivo = false;
                        }
                        else
                        {
                            jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posição já ocupada, tente novamente!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida, tente novamente!");
                    Console.ReadKey();
                }
            }
        }

        private void ExibirTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private bool MarcarPosicao(int posicao)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == posicao.ToString()[0])
                    {
                        tabuleiro[i, j] = jogadorAtual;
                        return true;
                    }
                }
            }
            return false;
        }

        private bool VerificarVitoria()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == jogadorAtual && tabuleiro[i, 1] == jogadorAtual && tabuleiro[i, 2] == jogadorAtual)
                    return true;
                if (tabuleiro[0, i] == jogadorAtual && tabuleiro[1, i] == jogadorAtual && tabuleiro[2, i] == jogadorAtual)
                    return true;
            }
            if (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual)
                return true;
            if (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            Jogo jogo = new Jogo();
            jogo.Iniciar();
        }
    }
}
