using System;
using System.Collections.Generic;

namespace TeachMeSkills.Pigal.Homework4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tasklog = new List<Todo>();
            bool inputStop = false;

            DateTime taskTime = default;
            ;

            string description = default;
            double duration = default;
            InputTasklogList(tasklog, duration, inputStop, taskTime, description);
            ShowTasklog(tasklog);
        }

        private static void InputTasklogList(List<Todo> tasklog, double duration, bool inputStop, DateTime taskTime, string description)
        {
            do
            {
                bool flag = true;
                while (flag)
                {
                    try
                    {
                        Console.Write("Insert task: ");
                        description = Console.ReadLine();
                        description = description.Trim();
                        if (description == "")
                        {
                            throw new Exception("Task was not entered");
                        }
                        flag = false;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.Write("Insert time for your task in format 00:00: ");
                bool result1 = DateTime.TryParse(Console.ReadLine(), out taskTime);
                if (result1 == true)
                {
                    Console.Write("Enter the duration of the task: ");
                    bool result2 = Double.TryParse(Console.ReadLine(), out duration);
                    if (result2 == true)
                    {
                        Todo todo = new Todo
                        {
                            Description = description,
                            TaskTime = taskTime,
                            TaskDuration = taskTime.AddMinutes(duration),
                        };

                        tasklog.Add(todo);

                        Console.WriteLine("Do you want to enter another task? Press any key or n. ");

                        var key = Console.ReadLine();

                        if (key != "n")
                        {
                            inputStop = false;
                        }
                        else
                        {
                            inputStop = true;
                        }
                    }
                }
            } while (!inputStop);
        }

        public static void ShowTasklog(List<Todo> tasklog)
        {
            Console.WriteLine(new string('=', 150));
            foreach (var todo in tasklog)
            {
                todo.GetInfo();
            }
            Console.WriteLine(new string('=', 150));
        }
    }
}