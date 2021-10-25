namespace TeachMeSkills.Pigal.Homework5.Models
{
    public abstract class AnimalBase<T>
    {
        public string Name { get; set; }
        public T Age { get; set; }
        public int Id { get; set; }

        public abstract void Eat();

        public abstract void Movin();
    }
}