using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your num:");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                for (int j = num; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                num--;

            }
               

            Console.ReadKey();
        }
    }
}
