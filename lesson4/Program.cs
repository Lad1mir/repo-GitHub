using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string fullName1 = GetFullName("Иван", "Иванов", "Иванович");
            string fullName2 = GetFullName("Василий", "Васильев", "Васильвевич");
            string fullName3 = GetFullName("Дмитрий", "Дмитриев", "Дмитриевич");
            Console.WriteLine(fullName1);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);

            //Задание 2

            Console.WriteLine("Введите числа через пробел");
            int getNum = FullSumm(Console.ReadLine());
            Console.WriteLine(getNum);

            //Задание 3

            Console.WriteLine("Введите номер месяца");
            int num = Convert.ToInt32(Console.ReadLine());
            Season season = GetSeason(num);
            if (season == Season.error)
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 12.");
            }
            else
            {
                string ru = RuSeason(season);
                Console.WriteLine(ru);
            }



            Console.ReadLine();
        }
        // Задание 1
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        // Задание 2
        static int FullSumm(string numbers)
        {
            string[] num = numbers.Split(' ');
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num[i]);
            }
            return sum;
        }
        // Задание 3
        enum Season
        {
            error,
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static Season GetSeason(int month)
        {
            switch (month)
            {
                case 1:
                    return Season.Winter;
                case 2:
                    return Season.Winter;
                case 3:
                    return Season.Spring;
                case 4:
                    return Season.Spring;
                case 5:
                    return Season.Spring;
                case 6:
                    return Season.Summer;
                case 7:
                    return Season.Summer;
                case 8:
                    return Season.Summer;
                case 9:
                    return Season.Autumn;
                case 10:
                    return Season.Autumn;
                case 11:
                    return Season.Autumn;
                case 12:
                    return Season.Winter;
                default:
                    return Season.error;
            }
        }

        static string RuSeason(Season ruSeason)
        {
            if (ruSeason == Season.Winter)
            {
                return "Зима";
            }
            else if (ruSeason == Season.Spring)
            {
                return "Весна";
            }
            else if (ruSeason == Season.Summer)
            {
                return "Лето";
            }
            else if (ruSeason == Season.Autumn)
            {
                return "Осень";
            }
            else
            {
                return "Ошибка: Введите число от 1 до 12.";
            }
        }


    }
}
