using StrategyPattern.Duck.Behaviors;
namespace StrategyPattern.Duck.ConcreteDucks
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck()
            : base( new FlyNoWay(), new MuteSound())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck.");
        }
        public override string ToString()
        {
            return "Decoy Duck\t" + FlyBehavior.ToString() + "\t" + QuackBehavior.ToString();
        }
    }
}