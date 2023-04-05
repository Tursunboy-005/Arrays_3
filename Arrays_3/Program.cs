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
            Console.Write("Massivning satrlar sonini kiriting: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Massivning ustunlar sonini kiriting: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[m, n];
            Console.WriteLine("Massivni kiriting:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("K butun sonni kiriting: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Massiv avval: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // k sonni topish
            bool found = false;
            int row = 0;
            int col = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == k)
                    {
                        found = true;
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            // Massivni 0 ga tenglab qo'yish
            if (found)
            {
                if (row > 0)
                {
                    arr[row - 1, col] = 0;
                }
                if (row < m - 1)
                {
                    arr[row + 1, col] = 0;
                }
                if (col > 0)
                {
                    arr[row, col - 1] = 0;
                }
                if (col < n - 1)
                {
                    arr[row, col + 1] = 0;
                }
            }

            Console.WriteLine("Massiv keyin: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
