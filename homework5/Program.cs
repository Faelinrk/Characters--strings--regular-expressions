using System;
using System.Text.RegularExpressions;

namespace homework5
{
    class Program
    {//Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин. Логин должен содержать от 2х до 10ти символов, содержащать только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
            string login = Console.ReadLine();
            while(login.Length > 10 || login.Length < 2 || !Regex.IsMatch(login, @"^[a-zA-Z][a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Формат логина неверен");
                login = Console.ReadLine();
            }
            Console.WriteLine("Формат логина верен");
            Console.ReadLine();
        } 
    }
}
