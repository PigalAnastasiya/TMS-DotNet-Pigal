using System;

namespace TeachMeSkills.Pigal.Homework2
{
    class Program
    {
        static void Main(string[] args)
        {


           bool flag = false;
            while (!flag)
           { 
                Console.Write("Enter date : ");
                string userInput = Console.ReadLine();
                bool result = DateTime.TryParse(userInput, out DateTime data);
                if (result == true)
                {
                    Console.WriteLine(data.DayOfWeek);
                    flag = true;
                }

                else
                    Console.WriteLine("Error: Uncorrect date!");

            }

        }
    }
}
