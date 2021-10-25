using System;

namespace TeachMeSkills.Pigal.Homework5.Models
{
    internal class Fish : AnimalBase<int>
    {
        public override void Eat()
        {
            Console.WriteLine("Рыба кушает водоросли");
        }

        public override void Movin()
        {
            Console.WriteLine("Рыба плавает");
        }
    }
}