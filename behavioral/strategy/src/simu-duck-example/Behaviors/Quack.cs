using System;

namespace SimUDuck.Console.Behaviors;

public class Quack : IQuackBehavior
{
    public void Quack() => System.Console.WriteLine("Quack! Quack!");
}