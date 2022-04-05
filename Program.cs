// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Swapping
{
    class Program 
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            swap S = new swap();
            S.Swap(input_1, input_2);
           


        }
    }
        class swap
        {
            int input_1;
            int input_2;
            public void Swap(int input_1, int input_2)
            {
                int temp;
                temp = input_1;
                input_1 = input_2;
                input_2 = temp;
                Console.WriteLine("Swapped output are: input_1= {0}, input_2 = {1}", input_1, input_2);
            }
        }
    }
