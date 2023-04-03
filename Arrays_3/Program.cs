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
            int[,] myArray =
            {
                { 1, 2, 3, 4 },
                { 4, 3, 2, 6 },
                { 9, 8, 7, 8 },
                { 6, 3, 6, 7 },
            };

            int Max = myArray[0,0];
            int Min = myArray[0,0];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for(int j = 0; j < myArray.GetLength(1); j++ )
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
