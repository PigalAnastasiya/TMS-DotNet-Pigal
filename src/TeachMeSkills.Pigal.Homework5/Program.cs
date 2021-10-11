using System;
using TeachMeSkills.Pigal.Homework5.Managers;

namespace TeachMeSkills.Pigal.Homework5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ZooManager zooManager = new ZooManager();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1: Add animal\n2: Delete animal\n3: Show all animal\n4: Exit");
                int number = Int32.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        zooManager.AddAnimal();
                        break;

                    case 2:
                        zooManager.Delete();
                        break;

                    case 3:
                        zooManager.Show();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}