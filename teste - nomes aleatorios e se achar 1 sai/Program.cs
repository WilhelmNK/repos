using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] Professores = { "Ailton", "Rodolfo", "Valter", "Juliano", "Cicero", "Marcio" };

            do
            {
                Console.Clear();
                int mIndex = rnd.Next(Professores.Length);

                
                Console.WriteLine("Ache o 'Ailton' para sair: ");
                Console.ReadKey();
                Console.WriteLine($"   Professor:     {Professores[mIndex]}");
                
                if (Professores[mIndex] == "Ailton")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ele e Careca");
                    break;
                }

                Console.ReadKey();
            } while (true);

            Console.ReadKey();
        }
    }
}
