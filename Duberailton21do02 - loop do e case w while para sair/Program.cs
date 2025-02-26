using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duberailton21do02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite um numero de 1 a 12 ou 0 para sair: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0) 
                    break;

                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Janeiro!");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro!");
                        break;
                    case 3:
                        Console.WriteLine("Março!");
                        break;
                    case 4:
                        Console.WriteLine("Abril!");
                        break;
                    case 5:
                        Console.WriteLine("Maio!");
                        break;
                    case 6:
                        Console.WriteLine("Junho!");
                        break;
                    case 7:
                        Console.WriteLine("Julho!");
                        break;
                    case 8:
                        Console.WriteLine("Agosto!");
                        break;
                    case 9:
                        Console.WriteLine("Setembro!");
                        break;
                    case 10:
                        Console.WriteLine("Outubro!");
                        break;
                    case 11:
                        Console.WriteLine("Novembro!");
                        break;
                    case 12: 
                        Console.WriteLine("Dezembro!"); 
                        break;
                    default: 
                        Console.WriteLine("Mês inválido!"); 
                        break;
                }

                Console.ReadKey();

            } while (true); 
        }
    }
}