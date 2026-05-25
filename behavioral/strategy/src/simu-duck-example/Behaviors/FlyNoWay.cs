using System;

namespace SimUDuck.Console.Behaviors;

public class FlyNoWay : IFlyBehavior
{
    public void Fly() => System.Console.WriteLine("<< Silence >> I can't fly. I'm grounded.");
}