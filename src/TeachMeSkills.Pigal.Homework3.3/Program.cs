using System;

namespace TeachMeSkills.Pigal.Homework3_3
{
    internal class Program
    {
        private static bool CheckUserInput(string userInput)
        {
            switch (userInput)
            {
                case "Monday": return true;

                case "Tuesday": return true;

                case "Wednesday": return true;

                case "Thursday": return true;

                case "Friday": return true;

                case "Saturday": return true;

                case "Sunday": return true;

                default: return false;
            }
        }

        private static DateTime[] GetDates()
        {
            var monthNow = DateTime.Now.Date.Month;
            var yearNow = DateTime.Now.Date.Year;
            var daysInMonth = DateTime.DaysInMonth(yearNow, monthNow);
            var dates = new DateTime[31];
            for (int i = 0; i < (daysInMonth); i++)
            {
                dates[i] = new DateTime(yearNow, monthNow, i + 1);
            }
            return dates;
        }

        private static void FindSuitableDates(DateTime[] dates, string userInput)
        {
            foreach (var date in dates)
            {
                if (userInput == date.DayOfWeek.ToString())
                {
                    Console.WriteLine(date.ToString("dd/MM/yyyy"));
                }
            }
        }

        private static void Main(string[] args)
        {
        again:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите значение дня недели (на анлийском)");
            string userInput = Console.ReadLine();
            var isCorrect = CheckUserInput(userInput);

            if (!isCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение для дня недели ");
                goto again;
            }
            Console.WriteLine(new string('-', 50));
            DateTime[] dates = GetDates();
            FindSuitableDates(dates, userInput);
        }
    }
}