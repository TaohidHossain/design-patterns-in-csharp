namespace StrategyPattern.Duck.Behaviors
{
    public interface IFlyBehavior
    {
        void Fly();
    }
    public class FlyWithWings: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
        public override string ToString()
        {
            return "Fly with wings";
        }
    }
    public class FlyNoWay: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
        public override string ToString()
        {
            return "Fly no way";
        }
    }
    public class FlyWithRocket: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rocket powered engine. Wohoo!");
        }
        public override string ToString()
        {
            return "Fly with rocket powered engine";
        }
    }

}

