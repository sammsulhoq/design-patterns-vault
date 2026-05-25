using System;

namespace SimUDuck.Console.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly() => System.Console.WriteLine("I'm flying with my biological wings! 🦆✨");
}