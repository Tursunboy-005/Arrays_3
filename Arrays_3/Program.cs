using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int m = rand.Next(2, 5);
            int n = rand.Next(2, 5);

            int[,] myArray = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = rand.Next(100);
                }
            }

            Console.WriteLine("Random Massiv: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", myArray[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write(" kerakli ustunni  kiriting : ");
            int k = int.Parse(Console.ReadLine());

            int sum = 0;
            int product = 1;
            for (int i = 0;i < myArray.GetLength(0);i++)
            {
                for(int j = 0;j < myArray.GetLength(1); j++)
                {
                    if(j == k)
                    {
                        sum += myArray[i, j];
                        product *= myArray[i,j];
                    }
                }
            }
            Console.WriteLine(" k ustundagi elementlar yigindisi {0}", sum);
            Console.WriteLine(" k ustundagi elementlar kopaytmasi {0}", product);

        }
    }
}
