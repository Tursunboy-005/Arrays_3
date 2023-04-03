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
            for (int i = 0;i < m;i++)
            {
                for (int j = 0;j < n;j++)
                {
                    myArray[i,j] = rand.Next(100);
                }
            }

            Console.WriteLine("Random Massiv: ");
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", myArray[i, j]);
                }
                Console.WriteLine();
            }


            int Max = myArray[0,0];
            int Min = myArray[0,0];

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++ )
                {
                    if (myArray[i, j] > Max)
                    {
                        Max = myArray[i, j];
                    }
                    if (myArray[i, j] < Min)
                    { 
                        Min = myArray[i, j];
                    }
                }
            }
            Console.WriteLine("Eng katta qiymat : {0} ", Max);
            Console.WriteLine("Eng kichik qiymat : {0} ", Min);

        }
    }
}
