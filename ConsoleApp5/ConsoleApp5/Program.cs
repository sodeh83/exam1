using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
    
                Console.Write("please your number:");
                int num1 = int.Parse(Console.ReadLine());
                int sum = 0;
                while (num1 != 0)
                {
                    int num2 = num1 % 10;
                    sum = sum + num2;
                    num1 = num1 / 10;
                }

                Console.WriteLine("the sum of digit this number is: {0}", sum);

                Console.ReadKey();

            }
        }
    }

