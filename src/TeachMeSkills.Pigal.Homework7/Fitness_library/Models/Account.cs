using System;

namespace Fitness.Library.Models
{/// <summary>
 /// Пользователь.
 /// </summary>
    public class Account
    {/// <summary>
     /// Логин.
     /// </summary>

        public string Login { get; set; }
        /// <summary>
        /// Пол.
        /// </summary>

        public Gender Gender { get; set; }
        /// <summary>
        /// Дата рождения.
        /// </summary>

        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Высота.
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return AgeCalculating(BirthDate); } }

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthday">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public Account(string login,
                       Gender gender,
                       DateTime birthday,
                       double weight,
                       double height)
        # region
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Логин не может быть пустым или null.", nameof(login));
            }
            if (gender == null)
            {
                //this.Gender = gender ?? throw new ArgumentNullException(nameof(gender));
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }
            if (birthday < DateTime.Parse("01.01.1950") || birthday >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения.", nameof(birthday));
            }
            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес не может быть меньше либо равен нулю.", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Рост не может быть меньше либо равен нулю.", nameof(height));
            }
            #endregion
            Login = login;
            Gender = gender;
            BirthDate = birthday;
            Weight = weight;
            Height = height;
        }

        /// <summary>
        /// Пользовательский конструктор класс Account
        /// </summary>
        /// <param name="login">Логин</param>
        public Account(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Логин не может быть пустым или null.", nameof(login));
            }
            Login = login;
        }

        public override string ToString()
        {
            return (Login + " возраст " + Age);
        }

        /// <summary>
        /// Расчет возраста
        /// </summary>
        /// <param name="Birthday">день рождения</param>
        /// <returns></returns>
        public int AgeCalculating(DateTime Birthday)
        {
            DateTime nowDate = DateTime.Today;
            int age = nowDate.Year - BirthDate.Year;
            if (BirthDate > nowDate.AddYears(-age)) age--;
            return age;
        }
    }
}