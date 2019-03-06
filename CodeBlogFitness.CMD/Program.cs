using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBlogFitness.BL.Controller;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");
            Console.Write("Введите имя пользователя: ");

            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.WriteLine("Введите пол");
                var gender = Console.ReadLine();
                DateTime birthDate = ParseDateTime();;
                double weight = ParseDouble("вес");
                double height = ParseDouble("рост");
                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine(userController.CurrentUser);
            Console.ReadKey();           

        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Введите дату рождения (dd.MM.yyyy):");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}");
                }
            }

        }
    }
}
