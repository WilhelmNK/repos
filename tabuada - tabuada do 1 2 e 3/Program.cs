using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Tab1 = 1;
            int Tab2 = 2;
            int Tab3 = 3;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Tab1} x {i} = {Tab1 * i}");
               
            }
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Tab2} x {i} = {Tab2 * i}");
                
            }
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Tab3} x {i} = {Tab3 * i}");
                
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
