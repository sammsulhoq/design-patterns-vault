using System;
using SimUDuck.Console.Behaviors;

namespace SimUDuck.Console.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new FlyNoWay(), new Squeak()) { }

    public override void Display() => System.Console.WriteLine("Looks exactly like a yellow rubber duckie.");
}