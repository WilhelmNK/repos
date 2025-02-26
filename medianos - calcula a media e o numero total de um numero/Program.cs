using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medianos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int TotalAluno;

            Console.Write("Quantos Alunos Tem na Academia? :  ");
            TotalAluno = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= TotalAluno; i++)
            {
                Console.Write($"Digite o peso da {i}º pessoa : ");
                double peso = Convert.ToDouble(Console.ReadLine());
                soma += peso;
            }

            double media = soma / TotalAluno;
            
            Math.Round(media, 2);

            Console.WriteLine("");
            Console.WriteLine($"A média dos pesos é: {media} kg");
            Console.WriteLine($"E o Peso Total foi {media = soma}");
            Console.ReadKey();
        }
        }

    }
