using Fitness.Date.Interfaces;

namespace Fitness.Date.Models
{
    public class Activity : IAction
    {
        public string LoginAction { get; set; }

        public Activity()
        { }

        public Activity(string login)
        {
            LoginAction = login;
        }

        /// <summary>
        /// Затрата калорий во время прогулки
        /// </summary>
        /// <param name="timeWalking">время прогулки в минутах</param>
        /// <returns></returns>
        public double Walking(double timeWalking)
        {
            const double caloriespertimewalking = 3.4;
            return timeWalking * caloriespertimewalking;
        }

        /// <summary>
        /// Затрата калорий во время бега
        /// </summary>
        /// <param name="timeRuning">время бега в минутах</param>
        /// <returns></returns>
        public double Run(double timeRuning)
        {
            const double caloriespertimerun = 5.8;
            return timeRuning * caloriespertimerun;
        }

        /// <summary>
        /// Затрата калорий во время езды на велосипеде
        /// </summary>
        /// <param name="timeDriving">время езды на велосипеде в минутах</param>
        /// <returns></returns>
        public double Driverbicycle(double timeDriving)
        {
            const double caloriespertimedriverbicycle = 9.2;
            return timeDriving * caloriespertimedriverbicycle;
        }

        /// <summary>
        /// Затрата калорий во время плавания
        /// </summary>
        /// <param name="timeSwiming">время плавания в минутах</param>
        /// <returns></returns>
        public double Swim(double timeSwiming)
        {
            const double caloriespertimedriverswim = 8.4;
            return timeSwiming * caloriespertimedriverswim;
        }
    }
}