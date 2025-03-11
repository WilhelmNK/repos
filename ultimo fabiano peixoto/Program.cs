internal class program
{
    private static void Main(string[] args)
    {
        string mensagem, comando;
        string jogador;
        string[,] tabuleiro;
        bool play;
        int posicaoX,posicaoY;


        mensagem = "fabiano peixoto";
        comando = "";
        tabuleiro = new string[10, 10]
        {
            // 0   1   2   3   4   5   6   7   8   9
            { "#","#","#","#","#","#","#","#","#","#" },// 0
            { "#"," "," "," "," ","?"," "," "," ","#" },// 1
            { "#"," "," "," "," "," "," "," "," ","#" },// 2
            { "#"," "," "," "," "," "," "," "," ","#" },// 3
            { "#"," "," "," "," "," "," "," "," ","#" },// 4
            { "#"," "," "," "," ","?"," "," "," ","#" },// 5
            { "#"," "," "," "," "," "," "," "," ","#" },// 6
            { "#"," "," "," "," "," "," "," "," ","#" },// 7
            { "#"," "," "," "," "," "," "," "," ","#" },// 8
            { "#","#","#","#","#","#","#","#","#","#" } // 9
        };
        posicaoX = 1;
        posicaoY = 1;
        jogador = "0";


    GameStart:
        Console.Clear();
        Console.WriteLine(mensagem);
        Console.WriteLine("B = blyat");
        Console.WriteLine("S = sair");
        comando = Console.ReadLine();

        if (comando.ToUpper() == "B")
        {
            play = true;

            while (play)
            {
                tabuleiro[posicaoY, posicaoX] = jogador;

                Console.Clear();


                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        Console.Write(tabuleiro[y, x]);
                    }
                    Console.WriteLine("");
                }
                
                
                Console.WriteLine("Digite as Teclas para se movimentar");
                Console.WriteLine("(A) - Esquerda");
                Console.WriteLine("(D) - Direita");
                Console.WriteLine("(W) - Cima");
                Console.WriteLine("(S) - Baixo");
                comando = Console.ReadLine();

                switch (comando.ToUpper())
                {
                    case "A":

                        if(tabuleiro[posicaoY,posicaoX-1] != "#")
                        {
                            tabuleiro[posicaoY, posicaoX] = " ";
                            posicaoX--;

                        }
                        else if (tabuleiro[posicaoY, posicaoX - 1] == "?")
                        {
                            Console.Beep();
                        }
                        break;
                    case "D":


                        if (tabuleiro[posicaoY, posicaoX] == "?")
                        {
                            Console.Beep();
                        }
                        else if (tabuleiro[posicaoY, posicaoX + 1] != "#")
                        {
                            tabuleiro[posicaoY, posicaoX] = " ";
                            posicaoX++;
                        }

                        break;
                    case "W":
                        if (tabuleiro[posicaoX, posicaoY - 1] != "#")
                        {
                            tabuleiro[posicaoY, posicaoX] = " ";
                            posicaoY--;
                        }
                        break;
                    case "S":
                        if (tabuleiro[posicaoX, posicaoY + 1] != "#")
                        {
                            tabuleiro[posicaoY, posicaoX] = " ";
                            posicaoY++;
                        }
                        break;
                    default:
                        Console.WriteLine("blyat ");
                        break;
                    
                }
            }
        }
 
        else if (comando.ToUpper() == "S")
        {
            Console.Beep();
            Console.WriteLine("nahui");
            Console.ReadKey();
        }
        else {
            goto GameStart;
        } 

    }
}