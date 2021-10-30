using Fitness.Library.Logic;
using Fitness.Library.Models;
using System;

namespace Fitness_Interface
{
    public class Program
    {
        public static UserManager controller = new UserManager();
        public static FootManeger footController = new FootManeger();

        public static FitnesManager fitnesManager = new FitnesManager();

        private static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness");
            bool comparison = true;
            while (comparison)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ВЫБЕРИТЕ КОМАНДУ:\n1 Добавление данных пользователя\n" +
                    "2 Добавление блюда\n3 Вывести информацию о пользователе \n" +
                    "4 Показать текущие данные употребленных элементов\n5 Добавить данные об тренировках \n6 Закончить работу с Fitness");
                Console.ResetColor();

                bool result = int.TryParse(Console.ReadLine(), out int number);
                if (result == true)
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Введите логин");
                            var username = Console.ReadLine();
                            var user = new Account(username);
                            // var colories = new Eating(user);

                            controller.CheckingLogin(username);
                            // var eating = new Eating(user);

                            break;

                        case 2:
                            Console.WriteLine("Введите название блюда:");
                            footController.CheckingFood(Console.ReadLine());
                            break;

                        case 6:
                            comparison = false;
                            break;

                        case 3:
                            Console.WriteLine("Информация о пользоватиле");
                            Console.WriteLine("Введите логин");
                            string name = Console.ReadLine();
                            controller.ShowUser(name);
                            //eating.Add(name,);
                            break;

                        case 5:

                            Console.WriteLine("Выберите активность :\n1 Ходьба\n2 Бег" +
                                              "\n3 Велосипед\n4 Плавание");
                            bool result1 = int.TryParse(Console.ReadLine(), out int number1);
                            if (result1 == true)
                            {
                                switch (number1)
                                {
                                    case 1:
                                        Console.WriteLine("Введите имя пользователя");
                                        string name1 = Console.ReadLine();
                                        Console.WriteLine("Введите время затраченное на тренировку в минутах");

                                        double timeWalking = Double.Parse(Console.ReadLine());
                                        fitnesManager.UpdateCaloriesWithWalking(name1, timeWalking);
                                        break;

                                    case 2:
                                        Console.WriteLine("Введите имя пользователя");
                                        string name2 = Console.ReadLine();
                                        Console.WriteLine("Введите время затраченное на тренировку в минутах");
                                        double timeRuning = Double.Parse(Console.ReadLine());
                                        fitnesManager.UpdateCaloriesWithRun(name2, timeRuning);
                                        break;

                                    case 3:
                                        Console.WriteLine("Введите имя пользователя");
                                        string name3 = Console.ReadLine();
                                        Console.WriteLine("Введите время затраченное на тренировку в минутах");
                                        double timeDriving = Double.Parse(Console.ReadLine());
                                        fitnesManager.UpdateCaloriesWithDriveBicycle(name3, timeDriving);
                                        break;

                                    case 4:
                                        Console.WriteLine("Введите имя пользователя");
                                        string name4 = Console.ReadLine();
                                        Console.WriteLine("Введите время затраченное на тренировку в минутах");
                                        double timeSwiming = Double.Parse(Console.ReadLine());
                                        fitnesManager.UpdateCaloriesWithSwiw(name4, timeSwiming);
                                        break;
                                }
                            }
                            break;

                        case 4:

                            Console.WriteLine("Информация о текущем количистве употребленных элементов: ");
                            Console.WriteLine($"Белки:{footController.ShowSumProteins()}");
                            Console.WriteLine($"Жиры:{footController.ShowSumFats()}");
                            Console.WriteLine($"Углеводы:{footController.ShowSumCabohydrates()}");
                            Console.WriteLine($"Калории:{footController.ShowSumCalories()}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введен некорректтный номер команды");
                }
            }
        }
    }
}