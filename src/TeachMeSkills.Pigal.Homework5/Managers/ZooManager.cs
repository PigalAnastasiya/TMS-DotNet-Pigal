using System;
using System.Collections.Generic;
using TeachMeSkills.Pigal.Homework5.Interfaces;
using TeachMeSkills.Pigal.Homework5.Models;

namespace TeachMeSkills.Pigal.Homework5.Managers
{
    public class ZooManager : IAddAnimal, IShowAnimal, IDeleteAnimal

    {
        public List<AnimalBase<int>> Animals { get; set; } = new List<AnimalBase<int>>();

        public void AddAnimal()
        {
            Console.WriteLine("Введите Id животного");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите название животного");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст животного");
            int age = Int32.Parse(Console.ReadLine());

        again:
            Console.WriteLine("Выберите номер, соответствующий классу животного\n1: Млекопитающие\t2: Птицы\t3: Рыбы");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Animals.Add(new Mammal
                    {
                        Name = name,
                        Age = age,
                        Id = id,
                    });
                    break;

                case 2:
                    Animals.Add(new Bird
                    {
                        Name = name,
                        Age = age,
                        Id = id,
                    });
                    break;

                case 3:
                    Animals.Add(new Fish
                    {
                        Name = name,
                        Age = age,
                        Id = id,
                    });
                    break;

                default:
                    Console.WriteLine("Введен неправильный номер. Попробуйте еще раз.");
                    goto again;
            }
            Console.WriteLine(new string('-', 50));
        }

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(new string('-', 100));
                Console.WriteLine($"Животное: {animal.Name},\tВозраст: {animal.Age}");
                animal.Eat();
                animal.Movin();
                Console.WriteLine(new string('-', 100));
            }
        }

        public void Delete()
        {
            Console.WriteLine("Введите Id животного, которого удалим из списка");
            int ID = Convert.ToInt32(Console.ReadLine());
            Animals.RemoveAt(ID - 1);
        }
    }
}