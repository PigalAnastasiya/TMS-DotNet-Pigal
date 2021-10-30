using Fitness.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitness.Library.Logic
{
    public class FootManeger
    {
        public List<Food> Foods = new List<Food>();
        public List<double> Calories = new List<double>();
        public List<double> Proteins = new List<double>();
        public List<double> Fats = new List<double>();
        public List<double> Cabohydrates = new List<double>();
        private double sumCalories = 0;
        private double sumProteins = 0;
        private double sumFats = 0;
        private double sumCabohydrates = 0;

        public bool IsNewFood { get; set; } = false;
        public Food CurrentFood { get; set; }

        public void CheckingFood(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название блюда не может быть пустым", nameof(name));
            }
            CurrentFood = Foods.SingleOrDefault(c => c.Name == name);
            if (CurrentFood == null)
            {
                CurrentFood = new Food(name);

                CreateNewFood(IsNewFood = true);
            }
        }

        /// <summary>
        /// Создание новой еды
        /// </summary>
        /// <param name="IsNewFood"></param>
        public void CreateNewFood(bool IsNewFood)
        {
            if (IsNewFood)
            {
                double proteins = ParseDouble("белки");
                double fats = ParseDouble("жиры");
                double cabohydrates = ParseDouble("углеводы");
                double calories = ParseDouble("калории");

                SetNewFoodData(proteins, fats, cabohydrates, calories);
            }

            Console.WriteLine($"Добавлено новое блюдо: {CurrentFood} - в 100 гр калорий {CurrentFood.Calories}");
        }

        /// <summary>
        /// Добавление новой еды в соответствующие списки
        /// </summary>
        /// <param name="proteins">белки</param>
        /// <param name="fats">жиры</param>
        /// <param name="cabohydrates">углеводы</param>
        /// <param name="calories">калории</param>
        public void SetNewFoodData(double proteins, double fats, double cabohydrates, double calories)
        {
            //TODO проверка
            CurrentFood.Proteins = proteins;
            CurrentFood.Fats = fats;
            CurrentFood.Cabohydrates = cabohydrates;
            CurrentFood.Calories = calories;
            Calories.Add(calories);
            Proteins.Add(proteins);
            Fats.Add(fats);
            Cabohydrates.Add(cabohydrates);
            Foods.Add(CurrentFood);
        }

        /// <summary>
        /// Превод в double
        /// </summary>
        /// <param name="name">значение</param>
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
        /// Посчет суммы калорий
        /// </summary>
        /// <param name="Calories">калории</param>
        /// <returns></returns>
        public double SumCalories(List<double> Calories)
        {
            foreach (double i in Calories)
            {
                sumCalories += i;
            }
            return sumCalories;
        }

        /// <summary>
        /// Подсчет количества белков
        /// </summary>
        /// <param name="Proteins">белки</param>
        /// <returns></returns>
        public double SumProteins(List<double> Proteins)
        {
            foreach (double i in Proteins)
            {
                sumProteins += i;
            }
            return sumProteins;
        }

        /// <summary>
        /// Подсчет количества жиры
        /// </summary>
        /// <param name="Fats">жиры</param>
        /// <returns></returns>
        public double SumFats(List<double> Fats)
        {
            foreach (double i in Fats)
            {
                sumFats += i;
            }
            return sumFats;
        }

        /// <summary>
        /// Подсчет количества углеводов
        /// </summary>
        /// <param name="Cabohydrates">углеводы</param>
        /// <returns></returns>
        public double SumCabohydrates(List<double> Cabohydrates)
        {
            foreach (double i in Cabohydrates)
            {
                sumCabohydrates += i;
            }
            return sumCabohydrates;
        }

        /// <summary>
        /// Вывод количество углеводов
        /// </summary>
        /// <returns></returns>
        public double ShowSumCabohydrates()
        {
            return SumCabohydrates(Cabohydrates);
        }

        /// <summary>
        /// Вывод количесво железа
        /// </summary>
        /// <returns></returns>
        public double ShowSumFats()
        {
            return SumFats(Fats);
        }

        /// <summary>
        /// Вывод количества белков
        /// </summary>
        /// <returns></returns>
        public double ShowSumProteins()
        {
            return SumProteins(Proteins);
        }

        /// <summary>
        /// Вывод количество калорий
        /// </summary>
        /// <returns></returns>
        public double ShowSumCalories()
        {
            return SumCalories(Calories);
        }
    }
}