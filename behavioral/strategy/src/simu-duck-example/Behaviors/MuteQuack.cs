using System;

namespace SimUDuck.Console.Behaviors;

public class MuteQuack : IQuackBehavior
{
    public void Quack() => System.Console.WriteLine("<< Muted >> Can't make sounds.");
}