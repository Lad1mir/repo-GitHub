using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        //Задание 1   
        {
            /* int nextString = 0;
             int[,] matrix = new int[5, 5];
             matrix[2, 2] = 1;
             for (int i = 0; i < matrix.GetLength(0); i++)
             {
                 for (int j = 0; j < matrix.GetLength(1); j++)
                 {
                     matrix[i, j] = nextString + 1;
                     Console.WriteLine($"{new string(' ', nextString)}{matrix[i, j]}");
                     nextString++;
                 }

             }*/

            //Задание 2
            /*string[,] phoneBook = new string[5, 2] { 
                { "Вася", "88002303030" }, 
                { "Петя", "89002303535" }, 
                { "Вова", "88005204040" }, 
                { "Саша", "89255605050" }, 
                { "Дима", "88004607070" } };


            for (int y = 0; y < phoneBook.GetLength(0); y++)
            {
                for (int x = 0; x < phoneBook.GetLength(1); x++)
                {
                    Console.Write(phoneBook[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); */

            //Задание 3
            /*Console.WriteLine("Введите любое слово или число");
            string rev = Console.ReadLine();
           
            for (int i = rev.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(rev[i]);
            }
            Console.ReadLine();*/
        }
    }
}
