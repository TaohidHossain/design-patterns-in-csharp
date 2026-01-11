using StrategyPattern.Duck;
using StrategyPattern.Duck.Behaviors;
using StrategyPattern.Duck.ConcreteDucks;

Duck mallard = new MallardDuck();
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();
Console.WriteLine(mallard);
Console.WriteLine();


Duck decoy = new DecoyDuck();
decoy.Display();
decoy.PerformFly();
decoy.PerformQuack();
Console.WriteLine(decoy);
Console.WriteLine();

Duck model = new ModelDuck();
model.Display();
model.PerformFly();
model.PerformQuack();
Console.WriteLine(model);
model.FlyBehavior = new FlyWithRocket();
model.PerformFly();
Console.WriteLine(model);
