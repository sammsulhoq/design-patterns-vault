using System;
using SimUDuck.Console.Behaviors;

namespace SimUDuck.Console.Ducks;

public class RedheadDuck : Duck
{
    public RedheadDuck() : base(new FlyWithWings(), new Quack()) { }

    public override void Display() => System.Console.WriteLine("Looks like a wild Redhead duck.");
}