using System;
using SimUDuck.Console.Ducks;
using SimUDuck.Console.Behaviors;

// Using Top-Level Statements (Modern C# Standard)
Console.WriteLine("========================================");
Console.WriteLine("    SimUDuck Strategy Pattern Demo      ");
Console.WriteLine("========================================\n");

Duck mallard = new MallardDuck();
mallard.Display();
mallard.PerformQuack();
mallard.PerformFly();

Console.WriteLine("\n----------------------------------------\n");

Duck rubberDuckie = new RubberDuck();
rubberDuckie.Display();
rubberDuckie.PerformQuack();
rubberDuckie.PerformFly();

// Runtime Strategy Swap Demonstration
Console.WriteLine("\n>>> Upgrading Rubber Duck with Rocket Boosters... <<<");
rubberDuckie.FlyBehavior = new FlyWithWings(); 

Console.Write("New Capability: ");
rubberDuckie.PerformFly(); 

Console.WriteLine("\n========================================");