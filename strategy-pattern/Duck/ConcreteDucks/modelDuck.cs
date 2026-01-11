using StrategyPattern.Duck.Behaviors;
namespace StrategyPattern.Duck.ConcreteDucks
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
            : base( new FlyNoWay(), new QuackSound())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
        public override string ToString()
        {
            return "Model Duck\t" + FlyBehavior.ToString() + "\t" + QuackBehavior.ToString();
        }
    }
}