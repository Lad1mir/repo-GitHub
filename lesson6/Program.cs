using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    [Serializable]
    public class MyArraySizeException : Exception { } 
    public class MyArrayDataException : Exception { }



    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            string[,] numbers = new string[4, 4]
            {
                {"1", "1", "1", "1"},
                {"2", "2", "2", "2"},
                {"3", "3", "3", "3"},
                {"4", "4", "4", "4"},
            };
            try
            {
                Console.WriteLine(Exceptions(numbers));
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            Console.ReadLine();
            //Задание 1
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                string result = $"{processes[i].ProcessName} id: {processes[i].Id}";
                Console.WriteLine(result);
            }
            Console.WriteLine("Введите имя процесса, который хотите закрыть");
            Process[] name = Process.GetProcessesByName(Console.ReadLine());
            for (int i = 0; i < name.Length; i++)
            {
                name[i].Kill();
            }
            Console.ReadLine();

        }
        //Задание 2 
        static int Exceptions(string[,] arrayName)
        {
            int sum = 0;
            if (arrayName.GetLength(0) != 4 || arrayName.GetLength(1) != 4)
            {
                throw new MyArraySizeException();
            }
            for (int i = 0; i < arrayName.GetLength(0); i++)
            {
                for (int j = 0; j < arrayName.GetLength(1); j++)
                {
                    try
                    {
                        sum += Convert.ToInt32(arrayName[i, j]);
                    }
                    catch 
                    {
                        throw new MyArrayDataException();
                    }
                }
            }
            return sum;
           
        }


    }
}
