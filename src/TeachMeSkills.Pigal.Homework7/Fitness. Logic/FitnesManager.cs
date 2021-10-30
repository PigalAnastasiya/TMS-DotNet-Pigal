using Fitness.Date.Models;
using System;
using System.Collections.Generic;

namespace Fitness.Library.Logic
{
    public class FitnesManager
    {
        public static Activity activity = new Activity();
        public List<Activity> tracker = new List<Activity>();

        /// <summary>
        /// Вычесление сжигаемых калорий во время прогулки
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="timeWalking">Время прогулки</param>
        public void UpdateCaloriesWithWalking(string login, double timeWalking)
        {
            Activity activity = new Activity();
            var walking = activity.Walking(timeWalking);
            tracker.Add(activity);
            Console.WriteLine($"{login} во время прогулки сжег {walking} калорий");
        }

        /// <summary>
        /// Вычесление сжигаемых калорий во время бега
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="timeRuning">время бега</param>
        public void UpdateCaloriesWithRun(string login, double timeRuning)
        {
            Activity activity = new Activity();
            var runing = activity.Run(timeRuning);
            tracker.Add(activity);
            Console.WriteLine($"{login} во время бега сжег {runing} калорий");
        }

        /// <summary>
        /// Вычесление сжигаемых калорий во время езды на велосипеде
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="timeDriving">время езды</param>
        public void UpdateCaloriesWithDriveBicycle(string login, double timeDriving)
        {
            Activity activity = new Activity();
            var driving = activity.Driverbicycle(timeDriving);
            tracker.Add(activity);
            Console.WriteLine($"{login} во время езды на велосипеде сжег {driving} калорий");
        }

        /// <summary>
        /// Вычесление сжигаемых калорий во время плавания
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="timeSwiming">время плавания</param>
        public void UpdateCaloriesWithSwiw(string login, double timeSwiming)
        {
            Activity activity = new Activity();
            var swiming = activity.Swim(timeSwiming);
            tracker.Add(activity);
            Console.WriteLine($"{login} во время плаванья на велосипеде сжег {swiming} калорий");
        }
    }
}