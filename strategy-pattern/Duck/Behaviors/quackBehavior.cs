namespace StrategyPattern.Duck.Behaviors
{
    public interface IQuackBehavior
    {
        void Quack();
    }
    public class QuackSound: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack.");
        }
        public override string ToString()
        {
            return "Quack Behavior";
        }
    }
    public class SqueakSound: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak.");
        }
        public override string ToString()
        {
            return "Squeak Behavior";
        }
    }
    public class MuteSound: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
        public override string ToString()
        {
            return "Mute Behavior";
        }
    }
}