using System;

namespace TeachMeSkills.Pigal.Homework5.Models
{
    public class Bird : AnimalBase<int>
    {
        public override void Eat()
        {
            Console.WriteLine("Птица кушает насекомых");
        }

        public override void Movin()
        {
            Console.WriteLine("Птица летают");
        }
    }
}