using StrategyPattern.Duck.Behaviors;
namespace StrategyPattern.Duck.ConcreteDucks
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
            : base( new FlyWithWings(), new QuackSound())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck.");
        }
    public override string ToString()
        {
            return "Mallard Duck\t" + FlyBehavior.ToString() + "\t" + QuackBehavior.ToString();
        }
    }
}