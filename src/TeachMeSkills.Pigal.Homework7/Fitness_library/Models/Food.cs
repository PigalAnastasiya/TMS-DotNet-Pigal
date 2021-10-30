namespace Fitness.Library.Models
{
    public class Food
    {
        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; set; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; set; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Cabohydrates { get; set; }

        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        public double Calories { get; set; }

        // public string LoginUserEatFood { get; set { Login. } }

        public Food(string name)
        {
            //TODO Проверка
            Name = name;
        }

        //public Food(string name) : this(name, 0, 0, 0, 0) { }

        public Food(string name, double callories, double proteins,
                    double fats, double cabohydrates)
        {
            //TODO Проверка
            Name = name;
            Calories = callories;
            Proteins = proteins;
            Fats = fats;
            Cabohydrates = cabohydrates;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}