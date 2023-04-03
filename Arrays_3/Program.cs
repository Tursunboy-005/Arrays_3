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
            
            Random random = new Random();
           
            int length = random.Next(5, 11); 
           
            int[][] myJaggedArray = new int[length][];
         
            for (int i = 0; i < length; i++)
            {
                myJaggedArray[i] = new int[random.Next(1, 6)]; 
            }
           
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    myJaggedArray[i][j] = random.Next(100); 
                }
            }
           
            for (int i = 0; i < length; i++)
            {
                Console.Write("Row {0}: ", i);
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write("{0} ", myJaggedArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

