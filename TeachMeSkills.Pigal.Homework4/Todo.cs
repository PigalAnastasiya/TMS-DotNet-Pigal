using System;

namespace TeachMeSkills.Pigal.Homework4
{
    internal class Todo
    {
        private readonly DateTime _dateTime = DateTime.Now;

        public DateTime TaskTime { get; set; }
        public string Description { get; set; }
        public DateTime TaskDuration { get; set; }

        public void GetInfo()
        {
            Console.BufferWidth = 150;
            Console.WriteLine($"Task: {Description}\tTask duration: {TaskTime} => {TaskDuration}\tTask create: {_dateTime}");
        }
    }
}