using System;

namespace TeachMeSkills.Pigal.Homework5.Models
{
    public class Mammal : AnimalBase<int>
    {
        public override void Eat()
        {
            Console.WriteLine("Хищники кушают мясо,а травоядные едят растения");
        }

        public override void Movin()
        {
            Console.WriteLine("Млекопитающее бегает");
        }
    }
}