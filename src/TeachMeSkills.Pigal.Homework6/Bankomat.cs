using System;
using System.Collections.Generic;
using System.Linq;

namespace TeachMeSkills.Pigal.Homework6
{
    internal class Bankomat
    {
        public delegate void Message(string message);

        public event Message Notify;

        private List<Card> cards = new List<Card>();

        /// <summary>
        /// Создание новых карт.
        /// </summary>
        /// <param name="numberID"> Id номер</param>
        /// <param name="pin"> PinCode</param>
        /// <param name="fullname"> Полное имя</param>
        /// <param name="balance">Денег на счету</param>
        public void Addcards(string numberID, string pin, string fullname, decimal balance)
        {
            Card card = new Card(numberID, pin, fullname, balance);
            cards.Add(card);
        }

        /// <summary>
        /// Вывод баланса карточки
        /// </summary>
        /// <param name="numbercard">Номет ID карты</param>
        public void GetClientBalance(string numbercard)
        {
            Card card = cards.SingleOrDefault(c => c.ID == numbercard);
            if (card != null)
            {
                Console.WriteLine("Баланс вашего счета: " + card.GetBalance());
                Console.WriteLine(new string('-', 100));
            }
        }

        /// <summary>
        /// Снимаем деньги с карточки.
        /// </summary>
        /// <param name="numbercard">Номер id карточки</param>
        /// <param name="money">Сумма для снятия с карточки</param>
        public void Take(string numbercard, decimal money)
        {
            Card card = cards.SingleOrDefault(c => c.ID == numbercard);
            if (card != null)
            {
                if (money % 10 != 0)
                    throw new ArgumentException("Снимаемая сумма должна быть кратна 10");
                decimal clientBalance = card.GetBalance();
                if (clientBalance > money)
                {
                    card.UpdateBalance(-money);
                    Notify?.Invoke($"{money} снято с вашей карточки");
                    Console.WriteLine(new string('-', 100));
                }
                else
                {
                    Notify?.Invoke("На карточке нет столько денег");
                }
            }
        }

        /// <summary>
        /// Добавление денег на баланс карточки.
        /// </summary>
        /// <param name="numbercard"> Id карточки</param>
        /// <param name="money">Сумма, добавляемая на карточку</param>
        public void Put(string numbercard, decimal money)
        {
            Card card = cards.SingleOrDefault(c => c.ID == numbercard);
            if (card != null)
            {
                card.UpdateBalance(money);
                Notify?.Invoke($"{money} добавлено на счет ");
                Console.WriteLine(new string('-', 100));
            }
        }

        /// <summary>
        /// Проверка данных клиента карточки
        /// </summary>
        /// <param name="numbercode"> Id карточки</param>
        /// <param name="pincode">pincode карточки</param>
        /// <returns></returns>
        public bool CheckClient(string numbercode, string pincode)
        {
            bool cheking = false;
            Card card = cards.SingleOrDefault(c => c.ID == numbercode);
            if (card != null)
            {
                if (pincode == card.PinCode)
                {
                    string name = card.GetFullName();
                    Console.WriteLine($"{name} welcome in the bankomat");
                    Console.WriteLine(new string('-', 100));
                    cheking = true;
                }
                else
                {
                    Console.WriteLine("Incorrect password entered");
                    cheking = false;
                }
            }
            else
            {
                Console.Write("Card not found.\t");
            }
            return cheking;
        }
    }
}