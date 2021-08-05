using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork5

 

{
    //Задание 4
    public class Person
    {
        public Person(string fullName, string position, string email, string phoneNumber, int salary, int age)
        {
            FullName = fullName;
            Position = position;
            Email = email;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Age = age;
        }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        
        public void GetInfo()
        {
            Console.WriteLine($"ФИО:{FullName} \nДолжность:{Position} \nПочта:{Email}" +
                $" \nТелефон:{PhoneNumber} \nЗарплата:{Salary} \nВозраст:{Age} \n ---------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   // Задание 1
            string filename = "text.txt";
            File.WriteAllText(filename, "Something");

            // Задание 2
            string filename2 = "startup.txt";
            File.AppendAllText(filename2, DateTime.Now.TimeOfDay.ToString() + "\n");

            //Задание 3
            Console.WriteLine("Введите любые числа через пробел");
            string result = Console.ReadLine();
            byte[] bytesArray = GetBytes(result);
            File.WriteAllBytes("bytes.bin", bytesArray);

            //Задание 4
            Person[] persArray = new Person[5];
            persArray[0] = new Person("Ivanov Ivan Ivanovich", "Engineer", "Ivan@mail.ru", "88008303030", 55000, 35);
            persArray[1] = new Person("Vasiliev Vasiliy Vasilyevich", "Programmer", "vasya@mail.ru", "89009505050", 45000, 42);
            persArray[2] = new Person("Petrov Petr Petrovich", "Developer", "petr@mail.ru", "88009606060", 45000, 45);
            persArray[3] = new Person("Ivanova Anastasia Ivanovna", "Artist", "nastya@mail.ru", "89005607070", 40000, 30);
            persArray[4] = new Person("Egorov Igor Igorevich", "Artist", "igor@mail.ru", "89008802020", 30000, 22);

            for (int i = 0; i < persArray.Length; i++)
            {
                if (persArray[i].Age > 40)
                {
                    persArray[i].GetInfo();
                }
               
            }
            Console.ReadLine();

        }
        //Задание 3
        static byte[] GetBytes(string numbers)
        {
            string[] stringArray = numbers.Split(' ');
            byte[] bytes = new byte[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                bytes[i] = Convert.ToByte(stringArray[i]);
            }
            return bytes;
        }

    }
}
