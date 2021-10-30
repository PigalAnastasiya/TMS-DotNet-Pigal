namespace Fitness.Date.Interfaces
{
    public interface IAction
    {
        public double Walking(double timeWalking);

        public double Run(double timeRunning);

        public double Driverbicycle(double timeDriving);

        public double Swim(double timeSwimming);
    }
}