using System;

namespace TeachMeSkills.Pigal.Homework3._1
{
    public class Program
    {
        private static void FindNumberDayOfWeek(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Monday":
                    Console.WriteLine("Monday is first  day of week");
                    break;

                case "Tuesday":
                    Console.WriteLine("Tuesday is second day of week");
                    break;

                case "Wednesday":
                    Console.WriteLine("Wednesday is third day of week");
                    break;

                case "Thursday":
                    Console.WriteLine("Thursday is fourth day of week");
                    break;

                case "Friday":
                    Console.WriteLine("Friday is fifth day of week");
                    break;

                case "Saturday":
                    Console.WriteLine("Saturday is sixth day of week");
                    break;

                case "Sunday":
                    Console.WriteLine("Sunday is seventh day of week");
                    break;

                default:
                    Console.WriteLine("the name of the day of the week is wrong");
                    break;
            }
        }

        private static void Main(string[] args)
        {
            string dayOfWeek;
            bool flag = false;
            while (!flag)
            {
                Console.Write("Enter date : ");
                string userInput = Console.ReadLine();
                bool result = DateTime.TryParse(userInput, out DateTime data);
                if (result == true)
                {
                    dayOfWeek = Convert.ToString(data.DayOfWeek);
                    FindNumberDayOfWeek(dayOfWeek);
                    flag = true;
                }
                else
                    Console.WriteLine("Error: Uncorrect date!");
            }
        }
    }
}