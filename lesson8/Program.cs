using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
             
            int rowBegin = 0, rowFinal = 0, columnBegin = 0, columnFinal = 0;
            int k = 1; int row = 0; int column = 0;
                
            while (k <= numbers.GetLength(0) * numbers.GetLength(1))
            {
                numbers[row, column] = k;
                if (row == rowBegin && column < numbers.GetLength(1) - columnFinal - 1)
                    ++column;
                else if (column == numbers.GetLength(1) - columnFinal - 1 && row < numbers.GetLength(0) - rowFinal - 1)
                    ++row;
                else if (row == numbers.GetLength(0) - rowFinal - 1 && column > columnBegin)
                    --column;
                else
                    --row;

                if ((row == rowBegin + 1) && (column == columnBegin) && (columnBegin != numbers.GetLength(1) - columnFinal - 1))
                {
                    ++rowBegin;
                    ++rowFinal;
                    ++columnBegin;
                    ++columnFinal;
                }
                ++k;
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
                                       
        }       


    }
}
