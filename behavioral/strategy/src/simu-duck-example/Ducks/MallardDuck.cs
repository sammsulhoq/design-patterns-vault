using System;
using SimUDuck.Console.Behaviors;

namespace SimUDuck.Console.Ducks;

public class MallardDuck : Duck
{
    // Pass real duck configurations cleanly to the base constructor
    public MallardDuck() : base(new FlyWithWings(), new Quack()) { }

    public override void Display() => System.Console.WriteLine("Looks like a real wild Mallard duck.");
}