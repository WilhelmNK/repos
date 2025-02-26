using System;

namespace AleatorioPorcentagem
{
    internal class Program
    {
        private static Random s_Random = new Random();
        static void Main(string[] args)
        {
            string[] Professores = { "Ailton", "Rodolfo", "Valter", "Juliano", "Cicero", "Marcio" };
            
            int[] porcentagens = { 1, 25, 30, 4, 35, 5 };

            //Ailton (1%): intervalo [1, 1]
            //Rodolfo(25 %): intervalo[2, 26]
            //Valter(30 %): intervalo[27, 56]
            //Juliano(4 %): intervalo[57, 60]
            //Cicero(35 %): intervalo[61, 95]
            //Marcio(5 %): intervalo[95, 100]

            int[] intervalos = new int[porcentagens.Length];
            int acumulada = 0;
            for (int i = 0; i < porcentagens.Length; i++)
            {
                acumulada += porcentagens[i];
                intervalos[i] = acumulada;
            }

            do
            {
                Console.Clear();
                int perCent = s_Random.Next(1, 101); 

                int index = Array.FindIndex(intervalos, intervalo => perCent <= intervalo);

                Console.WriteLine($"Porcentagem sorteada: {perCent}%");
                Console.WriteLine($"Professor sorteado: {Professores[index]} ({porcentagens[index]}%)");
                if (Professores[index] == "Ailton")
                {
                    Console.WriteLine("Ele é Careca");
                    break; 
                }
                Console.ReadKey();
            } while (true);

            Console.ReadKey();
        }
    }
}
