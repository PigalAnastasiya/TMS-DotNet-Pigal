using Fitness.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitness.Library.Logic
{
    public class UserManager
    {
        private List<Account> client = new List<Account>();
        protected List<string> users = new List<string>();
        public Account CurrentUser { get; set; }
        public bool IsNewUser { get; set; } = false;

        /// <summary>
        /// Проверка логина.
        /// </summary>
        /// <param name="userName">логин</param>
        public void CheckingLogin(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }
            CurrentUser = client.SingleOrDefault(c => c.Login == userName);
            if (CurrentUser == null)
            {
                users.Add(userName);
                CurrentUser = new Account(userName);

                CreateAccount(IsNewUser = true);
            }
        }

        /// <summary>
        /// Создание аккаунта.
        /// </summary>
        public void CreateAccount(bool IsNewUser)
        {
            if (IsNewUser)
            {
                Console.WriteLine("Введите пол");
                var gender = Console.ReadLine();

                double weight = ParseDouble("вес");
                double height = ParseDouble("рост");
                DateTime birthDate = ParseDateTime();

                SetNewUserData(gender, birthDate, weight, height);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Зарегистрированн новый пользователь: {CurrentUser}");
            Console.ResetColor();
        }

        /// <summary>
        /// Приведение из string в double
        /// </summary>
        /// <param name="name">переменная типа string</param>
        /// <returns></returns>
        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.WriteLine($"Введите {name}");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Неверный формат ввода ", nameof(name));
                }
            }
        }

        /// <summary>
        /// Приведение из string в DateTime
        /// </summary>
        /// <returns></returns>
        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Введите дату рождения");
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

        /// <summary>
        /// Запись в список нового пользователя
        /// </summary>
        /// <param name="genderName">пол</param>
        /// <param name="birthday">день рождения</param>
        /// <param name="weight">вес</param>
        /// <param name="height">рост</param>
        public void SetNewUserData(string genderName, DateTime birthday,
            double weight = 1, double height = 1)
        {
            //TODO проверка
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthday;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            client.Add(CurrentUser);
        }

        public void ShowUser(string name)
        {
            foreach (Account p in client)
            {
                if (p.Login == name)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(p);
                    Console.ResetColor();
                }
            }
        }
    }
}