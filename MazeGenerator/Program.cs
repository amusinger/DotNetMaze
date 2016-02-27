using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            bool[,] a = new bool[n, n];

            Random rand = new Random();

            int[,] ar = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ar[i, j] = rand.Next(0, n / 10);
                }
            }

            for (int j = 0; j < n; j++)
            {
                ar[j, 0] = 0;
                ar[j, n - 1] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ar[i, j] == 0)
                    {
                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

           
        }

     
    }
}