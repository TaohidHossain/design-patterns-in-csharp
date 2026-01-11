using StrategyPattern.Duck.Behaviors;

namespace StrategyPattern.Duck
{
    public abstract class Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        public IFlyBehavior FlyBehavior { get; set; } = flyBehavior;
        public IQuackBehavior QuackBehavior { get; set; } = quackBehavior;

        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks can swim");
        }
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }
}