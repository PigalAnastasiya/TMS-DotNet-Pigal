using System;

namespace TeachMeSkills.Pigal.Homework6
{
    internal class Card
    { /// <summary>
      /// Id номер карочки.
      /// </summary>
        public string ID { get; }

        /// <summary>
        /// Pin code карточки
        /// </summary>
        public string PinCode { get; }

        /// <summary>
        /// Полное имя держателя карточки.
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// Баланс карточки.
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Пользовательский конструктор класс Card
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="pin">PinCode</param>
        /// <param name="name">Имя владельца</param>
        /// <param name="balance">Баланс счета</param>

        public Card(string id, string pin, string name, decimal balance)
        {
            ID = id;
            PinCode = pin;
            FullName = name;
            Balance = balance;
        }

        /// <summary>
        /// Получение баланса карточки
        /// </summary>
        /// <returns></returns>
        public decimal GetBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Получение имени клиента, которому принадлежит карточка.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return FullName;
        }

        /// <summary>
        /// Изменение баланса карточки.
        /// </summary>
        /// <param name="money"></param>
        public void UpdateBalance(decimal money)
        {
            Balance += money;
        }

        /// <summary>
        /// Вывод информации о счете.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Id карточки {0}\nИмя владельца карточки:{1}\n Баланс карточки {2}", ID, FullName, Balance);
        }
    }
}