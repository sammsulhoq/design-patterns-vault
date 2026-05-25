using System;

namespace SimUDuck.Console.Behaviors;

public class Squeak : IQuackBehavior
{
    public void Quack() => System.Console.WriteLine("Squeak! Squeak! (Rubber duck sound)");
}