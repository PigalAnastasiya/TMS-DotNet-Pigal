using System;

namespace TeachMeSkills.Pigal.Homework6
{
    internal class Program
    {
        public static Bankomat bankomat = new Bankomat();

        /// <summary>
        /// Добавление карт
        /// </summary>
        public static void AddCard()
        {
            bankomat.Addcards("123456", "1234", "Иванов Иван Иванович", 0m);
            bankomat.Addcards("654321", "4321", "Петров Петр Петрович", 100m);
            bankomat.Addcards("123654", "3654", "Сидоров Петр Иванович", 200m);
        }

        /// <summary>
        /// Вывод операций с картой
        /// </summary>
        public static void ShowOperation()
        {
            Console.WriteLine("Select an operation:" +
                "\n1:Get Balance" +
                "\n2:Take money on card" +
                "\n3:Put money on card" +
                "\n4:Exit");
        }

        /// <summary>
        /// Вывод сообщения через события
        /// </summary>
        /// <param name="message">Сообщение</param>
        private static void Message(string message)
        {
            Console.WriteLine(message);
        }

        private static void Main(string[] args)
        {
            AddCard();
            bankomat.Notify += Message;
        again:
            Console.Write("Ведите Id карточки: ");
            var numbercode = Console.ReadLine();
            Console.Write("Введите Pin code: ");
            var pincode = Console.ReadLine();
            bool checking = bankomat.CheckClient(numbercode, pincode);
            if (checking == true)
            {
                while (true)
                {
                    ShowOperation();
                    bool exit = false;
                    int userInput = Int32.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            bankomat.GetClientBalance(numbercode);
                            break;

                        case 2:
                            try
                            {
                                Console.WriteLine("Введите сумму для снятия с карточки");
                                decimal money = Convert.ToDecimal(Console.ReadLine());

                                bankomat.Take(numbercode, money);
                            }
                            catch
                            {
                                Console.WriteLine("Некорректная сумма");
                            }
                            break;

                        case 3:
                            try
                            {
                                Console.WriteLine("Введите сумму для пополнения баланса карточки");
                                decimal money = Convert.ToDecimal(Console.ReadLine());
                                bankomat.Put(numbercode, money);
                            }
                            catch
                            {
                                Console.WriteLine("Некорректная сумма");
                            }
                            break;

                        case 4:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Не правильно выбрана комманда");
                            break;
                    }
                    if (exit == true) { break; }
                }
            }
            else
            {
                Console.WriteLine("Try again");
                goto again;
            }
        }
    }
}