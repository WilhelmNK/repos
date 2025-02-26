using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enforcer
{
    internal class Program
    {
        public static ConsoleColor BackgroundColor { get; set; }
        static void Main(string[] args)
        {
            int ctn;

            Random rnd = new Random();
            string[] Alimento = { "ailton", "careca" };

            int ALIindex = rnd.Next(Alimento.Length);

            string segredin = Alimento[ALIindex]; //segredin e a palavra aleatoria escolhida para tentar advinhar

            ctn = segredin.Length;  //aq conta o comprimento da palavra

            List<char> letrasCorretas = new List<char>(new char[ctn]);
            /* A List<char> cria uma variável que é uma lista dos caracteres corretos.  
               Para isso, usa new char[ctn], que cria um array(ou matriz) com '\0' em cada posição.  
               O número dentro de ctn define o tamanho do array, então se for 3, será: 
               '\0', '\0', '\0'.Isso ajuda na forca, pois armazena os espaços para as letras descobertas. */

            for (int i = 0; i < ctn; i++) letrasCorretas[i] = '_';// transforma os '/0' em '_' 

            int tentativas = 6; //numeros de tentativas ate acabar
            bool acertou = false; //Essa variavel guarda se o jogador acertou a palavra ou não.

            while (tentativas > 0 && !acertou)// loop do jogo (continua se as tetativas serem maior q 0
                                              // e se o jogador nao acertou ainda
            {
                Console.Clear();
                Console.WriteLine("Palavra: " + string.Join(" ", letrasCorretas));// ele mostra o progesso
                // do jogo, Join pega todos os elementos da lista letrasCorretas (que são caracteres)
                // e os junta em uma string Exemplo: Se a lista letrasCorretas estiver assim: ['_', '_', 'a', '_']
                // , o string.Join(" ", letrasCorretas) vai gerar a string:
                //"_ _ a _"

                Console.WriteLine($"Tentativas restantes: {tentativas}");
                Console.Write("Digite uma letra: ");
                char tentativa = Console.ReadKey().KeyChar; //armazena 1 caractere em tentativa
                Console.WriteLine();

                bool acertouLetra = false; // acertou esta como falso
                for (int i = 0; i < ctn; i++) //O laço continuará a rodar enquanto a variável i for menor que ctn
                {
                    if (segredin[i] == tentativa)
                    {
                        letrasCorretas[i] = tentativa;
                        acertouLetra = true;
                    }
                }

                if (!acertouLetra)
                {
                    tentativas--;
                }

                if (!letrasCorretas.Contains('_')) 
                    //se a variavel letrascorretas ainda tem _ ou seja se voce acertou alguma letra e n tem mais 
                {
                    acertou = true;
                }
            }

            Console.Clear();
            if (acertou) // se ele estiver true n tem mais _ na palavra
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Parabéns! Você acertou a palavra: {segredin}" );
                
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Fim de jogo! A palavra era: {segredin}");
                Console.ReadKey();
            }
        }
    }
}
