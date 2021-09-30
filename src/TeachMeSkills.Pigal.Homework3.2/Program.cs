using System;

namespace TeachMeSkills.Pigal.Homework3._2
{
    internal class Program
    {
        private static void FindNumberOfMonth(DateTime firstDay, out int number_month)
        {
            switch (Convert.ToString(firstDay.DayOfWeek))
            {
                case "Monday":
                    number_month = 1;
                    break;

                case "Tuesday":
                    number_month = 2;
                    break;

                case "Wednesday":
                    number_month = 3;
                    break;

                case "Thursday":
                    number_month = 4;
                    break;

                case "Friday":
                    number_month = 5;
                    break;

                case "Saturday":
                    number_month = 6;
                    break;

                default:
                    number_month = 7;
                    break;
            }
        }

        private static int DifferenceMonthNumbers(int number_month, int user_number_month)
        {
            if (number_month > user_number_month)
            {
                return number_month + (7 - number_month) - (number_month - user_number_month);
            }
            else
            {
                return user_number_month - number_month;
            }
        }

        private static void OutputDatesOfMonth(int dayDifference, int year, int month, DateTime firstDay)
        {
            while (dayDifference < DateTime.DaysInMonth(year, month))
            {
                Console.WriteLine(firstDay.AddDays(dayDifference).ToString("dd/MM/yyyy"));
                dayDifference += 7;
            }
        }

        private static void Main(string[] args)
        {
            int year, month;
            int number_month = default;
            Console.Write("Enter years: ");
            string input_year = Console.ReadLine();
            Console.Write("Enter month: ");
            string input_month = Console.ReadLine();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Monday : 1\tTuesday : 2 \nWednesday : 3\tThursday : 4\nFriday : 5\tSaturday : 6\tSunday : 7");
            Console.Write("\nEnter the number corresponding to the month according to the example above :  ");

            int user_number_month = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            if (!Int32.TryParse(input_year, out year))
            {
                Console.WriteLine("Type conversion error");
            }
            if (!Int32.TryParse(input_month, out month))
            {
                Console.WriteLine("Type conversion error");
            }

            DateTime firstDay = new DateTime(year, month, 1);
            FindNumberOfMonth(firstDay, out number_month);
            int dayDifference = DifferenceMonthNumbers(number_month, user_number_month);
            OutputDatesOfMonth(dayDifference, year, month, firstDay);
        }
    }
}